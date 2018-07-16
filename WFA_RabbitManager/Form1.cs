using CL_RabbitManager.Manager;
using CL_RabbitManager.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_RabbitManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private RabbitModel rabbitModel()
        {
            return new RabbitModel
            {
                Hostname = txtHostname.Text,
                Virtualname = txtVirtualName.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Exchangename = txtExchangeName.Text
            };
        }
        private User user()
        {
            return new User
            {
                Id = int.Parse(txtId.Text),
                Name = txtName.Text,
                Surname = txtSurname.Text,
            };
        }

        #region Direct Exchange
        private void btnDirectQueueCreate_Click(object sender, EventArgs e)
        {
            RabbitModel _model = rabbitModel();
            _model.Queuename = txtDirectQueueName.Text;
            _model.Routekey = txtDirectRouteKey.Text;

            RabbitMQDirectExchange manager = new RabbitMQDirectExchange(_model);
            manager.RabbitMQDirectExchangeQueueSet();
        }

        private async void btnDirectSend_Click(object sender, EventArgs e)
        {
            RabbitModel _model = rabbitModel();
            _model.Queuename = txtDirectQueueName.Text;
            _model.Routekey = txtDirectRouteKey.Text;

            methot(_model);
        }

        public async Task methot(RabbitModel _model)
        {
            RabbitMQDirectExchange manager = new RabbitMQDirectExchange(_model);
            manager.RabbitMQDirectExchangeSend(user());
        }

        private void lstDirect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] item = lstDirect.SelectedItem.ToString().Split('-');
            txtDirectQueueName.Text = item[0].Trim();
            txtDirectRouteKey.Text = item[1].Trim();
        }
        #endregion

        #region Fanout Exchange
        private void btnFanoutSend_Click(object sender, EventArgs e)
        {
            RabbitModel _model = rabbitModel();
            _model.Queuename = txtFanoutQueueName.Text;
            _model.Routekey = "";

            RabbitMQFanoutExchange manager = new RabbitMQFanoutExchange(_model);
            manager.RabbitMQFanoutExchangeSend(user());
        }

        private void btnFanoutQueueCreate_Click(object sender, EventArgs e)
        {
            RabbitModel _model = rabbitModel();
            _model.Queuename = txtFanoutQueueName.Text;
            _model.Routekey = "";

            RabbitMQFanoutExchange manager = new RabbitMQFanoutExchange(_model);
            manager.RabbitMQFanoutExchangeQueueCreate();
        }

        private void lstFanoutQueueList_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFanoutQueueName.Text = lstFanoutQueueList.SelectedItem.ToString();
        }
        #endregion

        #region Topic Exchange
        private void lstTopicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] item = lstTopicList.SelectedItem.ToString().Split('-');
            txtTopicQueueName.Text = item[0].Trim();
            txtTopicRouteKey.Text = item[1].Trim();
        }

        private void btnTopicSend_Click(object sender, EventArgs e)
        {
            RabbitModel _model = rabbitModel();
            _model.Queuename = txtTopicQueueName.Text;
            _model.Routekey = txtTopicRouteKey.Text;

            RabbitMQTopicExchange manager = new RabbitMQTopicExchange(_model);
            manager.RabbitMQTopicExchangeSend(user());
        }

        private void btnTopicQueueCreate_Click(object sender, EventArgs e)
        {
            RabbitModel _model = rabbitModel();
            _model.Queuename = txtTopicQueueName.Text;
            _model.Routekey = txtTopicRouteKey.Text;

            RabbitMQTopicExchange manager = new RabbitMQTopicExchange(_model);
            manager.RabbitMQTopicExchangeQueueCraete();
        }


        #endregion

        #region Header Exchange
        Dictionary<string, object> _headers = new Dictionary<string, object>();
        private void btnHeaderExchangeAdd_Click(object sender, EventArgs e)
        {
            string key = txtHeaderExchangeKey.Text;
            string value = txtHeaderExchangeValue.Text;

            _headers.Add(key, value);
            lstHeaderExchangeKeys.Items.Add(key + " - " + value);

            txtHeaderExchangeKey.Text = string.Empty;
            txtHeaderExchangeValue.Text = string.Empty;
        }

        private void btnHeaderExchangeQueueCreate_Click(object sender, EventArgs e)
        {
            RabbitModel headerRabbitModel = rabbitModel();
            headerRabbitModel.Queuename = txtHeaderExchangeQueueName.Text;
            headerRabbitModel.Routekey = "";
            headerRabbitModel.HeaderEchangeOptions = _headers;

            RabbitMQHeaderExchange manager = new RabbitMQHeaderExchange(headerRabbitModel);
            manager.RabbitMQDirectExchangeQueueCreate();

            lstHeaderExchangeKeys.Items.Clear();

            _headers.Clear();
            txtHeaderExchangeQueueName.Text = string.Empty;
        }

        private void btnHeaderExchangeSend_Click(object sender, EventArgs e)
        {
            RabbitModel headerRabbitModel = rabbitModel();
            headerRabbitModel.Queuename = txtHeaderExchangeQueueName.Text;
            headerRabbitModel.Routekey = "";
            headerRabbitModel.HeaderEchangeOptions = _headers;

            RabbitMQHeaderExchange manager = new RabbitMQHeaderExchange(headerRabbitModel);
            manager.RabbitMQDirectExchangeSend(user());

            lstHeaderExchangeKeys.Items.Clear();

            _headers.Clear();
            txtHeaderExchangeQueueName.Text = string.Empty;
        }

        #endregion
    }
}