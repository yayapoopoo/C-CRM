// Decompiled with JetBrains decompiler
// Type: SMART_CRM.ListViewEx
// Assembly: SMART CRM, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 8920CEC9-6723-48DC-9254-9D62FA2BA5D3
// Assembly location: C:\Users\THEOREUM\Dropbox\PC\Documents\카카오톡 받은 파일\SMART CRM 셋업파일\program files\SMART CRM\SMART CRM.exe

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WinFormsApp3
{
  public class ListViewEx : ListView
  {
    [DllImport("uxtheme", CharSet = CharSet.Auto)]
    private static extern bool SetWindowTheme(IntPtr hWindow, string subAppName, string subIDList);

    public ListViewEx() => this.SetStyle(ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);

    protected override void OnHandleCreated(EventArgs e)
    {
      base.OnHandleCreated(e);
      ListViewEx.SetWindowTheme(this.Handle, "explorer", (string) null);
    }
  }
}
