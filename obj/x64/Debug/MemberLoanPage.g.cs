﻿#pragma checksum "C:\Users\MehdiMarzougui_SysD\Desktop\Mehdi_Marzougui_REDL2R\Library Manager\MemberLoanPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FFE9F1FC031F45742B9A4257FF7F35CE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryManager
{
    partial class MemberLoanPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Automation_AutomationProperties_Name(global::Windows.UI.Xaml.DependencyObject obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                global::Windows.UI.Xaml.Automation.AutomationProperties.SetName(obj, value);
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MemberLoanPage_obj4_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMemberLoanPage_Bindings
        {
            private global::LibraryManager.BLL.Loan dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj4;
            private global::Windows.UI.Xaml.Controls.TextBlock obj5;
            private global::Windows.UI.Xaml.Controls.TextBlock obj6;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj4NameDisabled = false;
            private static bool isobj5TextDisabled = false;
            private static bool isobj6TextDisabled = false;

            public MemberLoanPage_obj4_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 28 && columnNumber == 81)
                {
                    isobj4NameDisabled = true;
                }
                else if (lineNumber == 29 && columnNumber == 36)
                {
                    isobj5TextDisabled = true;
                }
                else if (lineNumber == 30 && columnNumber == 36)
                {
                    isobj6TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 4: // MemberLoanPage.xaml line 28
                        this.obj4 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.StackPanel)target);
                        break;
                    case 5: // MemberLoanPage.xaml line 29
                        this.obj5 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 6: // MemberLoanPage.xaml line 30
                        this.obj6 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj4.Target as global::Windows.UI.Xaml.Controls.StackPanel).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::LibraryManager.BLL.Loan) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // IMemberLoanPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::LibraryManager.BLL.Loan)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::LibraryManager.BLL.Loan obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_item(obj.item, phase);
                        this.Update_dueToDate(obj.dueToDate, phase);
                    }
                }
            }
            private void Update_item(global::LibraryManager.BLL.Item obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_item_barcode(obj.barcode, phase);
                        this.Update_item_title(obj.title, phase);
                    }
                }
            }
            private void Update_item_barcode(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MemberLoanPage.xaml line 28
                    if (!isobj4NameDisabled)
                    {
                        if ((this.obj4.Target as global::Windows.UI.Xaml.Controls.StackPanel) != null)
                        {
                            XamlBindingSetters.Set_Windows_UI_Xaml_Automation_AutomationProperties_Name((this.obj4.Target as global::Windows.UI.Xaml.Controls.StackPanel), obj.ToString(), null);
                        }
                    }
                }
            }
            private void Update_item_title(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MemberLoanPage.xaml line 29
                    if (!isobj5TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj5, obj, null);
                    }
                }
            }
            private void Update_dueToDate(global::System.DateTime obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MemberLoanPage.xaml line 30
                    if (!isobj6TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj6, obj.ToString(), null);
                    }
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MemberLoanPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMemberLoanPage_Bindings
        {
            private global::LibraryManager.MemberLoanPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ListView obj2;
            private global::Windows.UI.Xaml.Controls.TextBlock obj10;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2ItemsSourceDisabled = false;
            private static bool isobj10TextDisabled = false;

            private MemberLoanPage_obj1_BindingsTracking bindingsTracking;

            public MemberLoanPage_obj1_Bindings()
            {
                this.bindingsTracking = new MemberLoanPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 25 && columnNumber == 55)
                {
                    isobj2ItemsSourceDisabled = true;
                }
                else if (lineNumber == 19 && columnNumber == 24)
                {
                    isobj10TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // MemberLoanPage.xaml line 25
                        this.obj2 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    case 10: // MemberLoanPage.xaml line 19
                        this.obj10 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IMemberLoanPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::LibraryManager.MemberLoanPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::LibraryManager.MemberLoanPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_loans(obj.loans, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_member(obj.member, phase);
                    }
                }
            }
            private void Update_loans(global::System.Collections.ObjectModel.ObservableCollection<global::LibraryManager.BLL.Loan> obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_loans(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // MemberLoanPage.xaml line 25
                    if (!isobj2ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj2, obj, null);
                    }
                }
            }
            private void Update_member(global::LibraryManager.BLL.Member obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_member_name(obj.name, phase);
                    }
                }
            }
            private void Update_member_name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MemberLoanPage.xaml line 19
                    if (!isobj10TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj10, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class MemberLoanPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<MemberLoanPage_obj1_Bindings> weakRefToBindingObj; 

                public MemberLoanPage_obj1_BindingsTracking(MemberLoanPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<MemberLoanPage_obj1_Bindings>(obj);
                }

                public MemberLoanPage_obj1_Bindings TryGetBindingObject()
                {
                    MemberLoanPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_loans(null);
                }

                public void PropertyChanged_loans(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MemberLoanPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::LibraryManager.BLL.Loan> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::LibraryManager.BLL.Loan>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_loans(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    MemberLoanPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::LibraryManager.BLL.Loan> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::LibraryManager.BLL.Loan>;
                    }
                }
                private global::System.Collections.ObjectModel.ObservableCollection<global::LibraryManager.BLL.Loan> cache_loans = null;
                public void UpdateChildListeners_loans(global::System.Collections.ObjectModel.ObservableCollection<global::LibraryManager.BLL.Loan> obj)
                {
                    if (obj != cache_loans)
                    {
                        if (cache_loans != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_loans).PropertyChanged -= PropertyChanged_loans;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)cache_loans).CollectionChanged -= CollectionChanged_loans;
                            cache_loans = null;
                        }
                        if (obj != null)
                        {
                            cache_loans = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_loans;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)obj).CollectionChanged += CollectionChanged_loans;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MemberLoanPage.xaml line 25
                {
                    this.LoansListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.LoansListView).SelectionChanged += this.ListView_SelectionChanged;
                }
                break;
            case 7: // MemberLoanPage.xaml line 22
                {
                    global::Windows.UI.Xaml.Controls.Button element7 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element7).Click += this.Loan_Book_Button_Click;
                }
                break;
            case 8: // MemberLoanPage.xaml line 23
                {
                    global::Windows.UI.Xaml.Controls.Button element8 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element8).Click += this.Loan_DVD_Button_Click;
                }
                break;
            case 9: // MemberLoanPage.xaml line 18
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element9 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element9).Click += this.Back_button_event;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // MemberLoanPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MemberLoanPage_obj1_Bindings bindings = new MemberLoanPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            case 4: // MemberLoanPage.xaml line 28
                {                    
                    global::Windows.UI.Xaml.Controls.StackPanel element4 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                    MemberLoanPage_obj4_Bindings bindings = new MemberLoanPage_obj4_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element4.DataContext);
                    element4.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element4, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element4, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

