﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace MineSweeper.Utils
{
    class TimerCounter
    {
        /// <summary>
        /// 使用实例
        /// 创建TimerCounter 的实例
        /// TimerCounter counter = new TimerCounter(textBlock);
        /// 
        ///   开始计时
        ///   counter.StartCountDown();
        ///     
        ///    获取⏲开始流逝的时间
        ///    counter.GetEllapsedTime();
        ///    
        ///  在Grid中使用一个TextBlock之类的展示控件展示
        ///  
        ///  只要传入一个TextBlock类就可以
        /// </summary>
        int Count = 0;

  
        System.Threading.Timer timer;
        TextBlock TextBlock;
        public TimerCounter(TextBlock textBlock)
        {
            this.TextBlock = textBlock;
        }
        public void StartCountDown()
        {
            //一旦创建出来就会执行时间记录
            timer = new System.Threading.Timer(TimerAction, null, TimeSpan.FromSeconds(2), TimeSpan.FromSeconds(1));
         
        }

        public void StopCountDown()
        {
            timer.Dispose();
            Count = 0;
            
        }

        public int GetEllapsedTime()
        {
            return Count;
        }


        public async void Invoke(Action action, Windows.UI.Core.CoreDispatcherPriority Priority = Windows.UI.Core.CoreDispatcherPriority.Normal)
        {
            await Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(Priority, () => { action(); });
        }

        private void TimerAction(object obj)
        {
            Count += 1;
            this.Invoke(() => {
            TextBlock.Text = Count.ToString();
            }
            );
        }

    }
}