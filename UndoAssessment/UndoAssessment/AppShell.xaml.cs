using System;
using System.Collections.Generic;
using UndoAssessment.ViewModels;
using UndoAssessment.Views;
using Xamarin.Forms;

namespace UndoAssessment
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}

