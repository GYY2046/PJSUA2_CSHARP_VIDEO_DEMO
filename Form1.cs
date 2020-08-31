using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pjsua2_csharp_video_demo
{
    public partial class Form1 : Form
    {
        public static Endpoint ep;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInit_Click(object sender, EventArgs e)
        {
            ep = new Endpoint();
            ep.libCreate();

            EpConfig epConfig = new EpConfig();
            epConfig.logConfig.writer = new DebugLog();

            ep.libInit(epConfig);

            TransportConfig tcfg = new TransportConfig();
            tcfg.port = 5060;

            ep.transportCreate(pjsip_transport_type_e.PJSIP_TRANSPORT_UDP,tcfg);
            ep.transportCreate(pjsip_transport_type_e.PJSIP_TRANSPORT_TCP,tcfg);
            // Start library
            ep.libStart();
            this.btnInit.Text = "初始化成功";
            this.btnInit.Enabled = false;
        }
        /// <summary>
        /// 获取摄像头
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectCamra_Click(object sender, EventArgs e)
        {
            var videoList = ep.vidDevManager().enumDev2();
            foreach(var item in videoList)
            {
                ListItems listItems = new ListItems(item.id.ToString(), item.name);
                comboxCamre.Items.Add(listItems);
            }
        }

        private void btnStartCamera_Click(object sender, EventArgs e)
        {
            
            var selectCamera = (ListItems)comboxCamre.SelectedItem;
            //VideoPreview preview = new VideoPreview(int.Parse(selectCamera.Key));
            //VideoPreviewOpParam videoPreviewOpParam = new VideoPreviewOpParam();
            //videoPreviewOpParam.window = new VideoWindowHandle();
            //videoPreviewOpParam.show = true;
            //videoPreviewOpParam.window.handle = new WindowHandle();
            //videoPreviewOpParam.window.handle.setWindow(this.panelCamera.Handle.ToInt64());


            //preview.start(videoPreviewOpParam);

            VideoPreview video = new VideoPreview((int)pjmedia_vid_dev_std_index.PJMEDIA_VID_DEFAULT_CAPTURE_DEV);            
            VideoPreviewOpParam videoPreviewOpParam = new VideoPreviewOpParam();
            videoPreviewOpParam.rendId = (int)pjmedia_vid_dev_std_index.PJMEDIA_VID_DEFAULT_RENDER_DEV;
            videoPreviewOpParam.show = true;

            video.start(videoPreviewOpParam);
            var window = video.getVideoWindow();
            var videoList = ep.vidDevManager().enumDev2();
      
            //var epdev = ep.vidDevManager().getOutputWindowFlags(-1);
            window.Show(false);

            MediaCoordinate coordinate = new MediaCoordinate();
            coordinate.x = 0;// this.panelCamera.Top;
            coordinate.y = 0;// this.panelCamera.Left;
            window.setPos(coordinate);

            MediaSize size = new MediaSize();
            size.h = (uint)this.panelCamera.Height;
            size.w = (uint)this.panelCamera.Width;
            window.setSize(size);

            var intPtr = EmbedControl.FindWindow(null, "pjmedia-SDL video");
            EmbedControl.SetParent(intPtr, this.panelCamera.Handle);
            //window.getInfo().isNative = false;
            window.Show(true);

            window.Show(true);
            //window.setFullScreen(true);
            //window.rotate(90);

            //VideoWindowHandle windowHandle = new VideoWindowHandle();
            //windowHandle.handle = new WindowHandle();
            //windowHandle.handle.setWindow(this.panelCamera.Handle.ToInt64());

            //window.setWindow(windowHandle);
            //window.rotate(90);

            //windowInfo.winHandle.handle.setWindow(this.panelCamera.Handle.ToInt64());
            //window.Show(true);


            //var windowInfo = window.getInfo();
            //windowInfo.isNative = false;
            //windowInfo.      
        }
    }
}
