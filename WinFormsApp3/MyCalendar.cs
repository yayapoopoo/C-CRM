// Decompiled with JetBrains decompiler
// Type: SMART_CRM.MyCalendar
// Assembly: SMART CRM, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 8920CEC9-6723-48DC-9254-9D62FA2BA5D3
// Assembly location: C:\Users\THEOREUM\Dropbox\PC\Documents\카카오톡 받은 파일\SMART CRM 셋업파일\program files\SMART CRM\SMART CRM.exe

using System;
using System.Windows.Forms;

namespace SMART_CRM
{
  public class MyCalendar : MonthCalendar
  {
    private int lastClickTick;

    public event EventHandler DoubleClickEx;

    public MyCalendar() => this.lastClickTick = Environment.TickCount - SystemInformation.DoubleClickTime;

    protected override void OnMouseDown(MouseEventArgs e)
    {
      int tickCount = Environment.TickCount;
      if (tickCount - this.lastClickTick <= SystemInformation.DoubleClickTime)
      {
        EventHandler doubleClickEx = this.DoubleClickEx;
        if (doubleClickEx == null)
          return;
        doubleClickEx((object) this, EventArgs.Empty);
      }
      else
      {
        base.OnMouseDown(e);
        this.lastClickTick = tickCount;
      }
    }
  }
}
