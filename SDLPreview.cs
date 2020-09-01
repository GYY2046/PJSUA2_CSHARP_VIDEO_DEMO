using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace pjsua2_csharp_video_demo
{
    public partial class SDLPreview : UserControl
    {
        const uint SDL_INIT_VIDEO = 32;
        //[DllImport("SDL2.dll", CallingConvention = CallingConvention.Cdecl)]
        [DllImport("SDL2.dll")]
        public static extern int SDL_Init(uint flags);
        /* data refers to some native window type, IntPtr to an SDL_Window* */

        [DllImport("SDL2.dll")]
        public static extern IntPtr SDL_CreateWindowFrom(IntPtr data);
        public SDLPreview()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SDL_Init(SDL_INIT_VIDEO);
            SDL_CreateWindowFrom(this.Handle);
            Debug.WriteLine(this.Handle.ToInt32());
        }
    }
}
