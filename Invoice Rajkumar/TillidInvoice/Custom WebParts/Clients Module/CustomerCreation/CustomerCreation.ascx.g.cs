﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TillidInvoice.Custom_WebParts.CustomerCreation {
    using System.Web.UI.WebControls.Expressions;
    using System.Web.UI.HtmlControls;
    using System.Collections;
    using System.Text;
    using System.Web.UI;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using Microsoft.SharePoint.WebPartPages;
    using System.Web.SessionState;
    using System.Configuration;
    using Microsoft.SharePoint;
    using System.Web;
    using System.Web.DynamicData;
    using System.Web.Caching;
    using System.Web.Profile;
    using System.ComponentModel.DataAnnotations;
    using System.Web.UI.WebControls;
    using System.Web.Security;
    using System;
    using Microsoft.SharePoint.Utilities;
    using System.Text.RegularExpressions;
    using System.Collections.Specialized;
    using System.Web.UI.WebControls.WebParts;
    using Microsoft.SharePoint.WebControls;
    
    
    public partial class CustomerCreation {
        
        protected global::System.Web.UI.WebControls.TextBox txtName;
        
        protected global::System.Web.UI.WebControls.RadioButtonList RadioStatus;
        
        protected global::System.Web.UI.WebControls.TextBox txtAddress;
        
        protected global::System.Web.UI.WebControls.TextBox txtEmail;
        
        protected global::System.Web.UI.WebControls.TextBox txtWebs;
        
        protected global::System.Web.UI.WebControls.TextBox txtPhone;
        
        protected global::System.Web.UI.WebControls.TextBox txtFax;
        
        protected global::System.Web.UI.WebControls.TextBox txtDescription;
        
        protected global::System.Web.UI.WebControls.Button Save;
        
        public static implicit operator global::System.Web.UI.TemplateControl(CustomerCreation target) 
        {
            return target == null ? null : target.TemplateControl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.TextBox @__BuildControltxtName() {
            global::System.Web.UI.WebControls.TextBox @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.TextBox();
            this.txtName = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "txtName";
            ((System.Web.UI.IAttributeAccessor)(@__ctrl)).SetAttribute("class", "form-control");
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.ListItem @__BuildControl__control3() {
            global::System.Web.UI.WebControls.ListItem @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.ListItem();
            @__ctrl.Text = "Active";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.ListItem @__BuildControl__control4() {
            global::System.Web.UI.WebControls.ListItem @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.ListItem();
            @__ctrl.Text = "InActive";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void @__BuildControl__control2(System.Web.UI.WebControls.ListItemCollection @__ctrl) {
            global::System.Web.UI.WebControls.ListItem @__ctrl1;
            @__ctrl1 = this.@__BuildControl__control3();
            @__ctrl.Add(@__ctrl1);
            global::System.Web.UI.WebControls.ListItem @__ctrl2;
            @__ctrl2 = this.@__BuildControl__control4();
            @__ctrl.Add(@__ctrl2);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.RadioButtonList @__BuildControlRadioStatus() {
            global::System.Web.UI.WebControls.RadioButtonList @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.RadioButtonList();
            this.RadioStatus = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "RadioStatus";
            ((System.Web.UI.IAttributeAccessor)(@__ctrl)).SetAttribute("class", "radio-inline");
            this.@__BuildControl__control2(@__ctrl.Items);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.TextBox @__BuildControltxtAddress() {
            global::System.Web.UI.WebControls.TextBox @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.TextBox();
            this.txtAddress = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "txtAddress";
            ((System.Web.UI.IAttributeAccessor)(@__ctrl)).SetAttribute("class", "form-control");
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.TextBox @__BuildControltxtEmail() {
            global::System.Web.UI.WebControls.TextBox @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.TextBox();
            this.txtEmail = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "txtEmail";
            ((System.Web.UI.IAttributeAccessor)(@__ctrl)).SetAttribute("class", "form-control");
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.TextBox @__BuildControltxtWebs() {
            global::System.Web.UI.WebControls.TextBox @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.TextBox();
            this.txtWebs = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "txtWebs";
            ((System.Web.UI.IAttributeAccessor)(@__ctrl)).SetAttribute("class", "form-control");
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.TextBox @__BuildControltxtPhone() {
            global::System.Web.UI.WebControls.TextBox @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.TextBox();
            this.txtPhone = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "txtPhone";
            ((System.Web.UI.IAttributeAccessor)(@__ctrl)).SetAttribute("class", "form-control");
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.TextBox @__BuildControltxtFax() {
            global::System.Web.UI.WebControls.TextBox @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.TextBox();
            this.txtFax = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "txtFax";
            ((System.Web.UI.IAttributeAccessor)(@__ctrl)).SetAttribute("class", "form-control");
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.TextBox @__BuildControltxtDescription() {
            global::System.Web.UI.WebControls.TextBox @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.TextBox();
            this.txtDescription = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "txtDescription";
            ((System.Web.UI.IAttributeAccessor)(@__ctrl)).SetAttribute("class", "form-control");
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Button @__BuildControlSave() {
            global::System.Web.UI.WebControls.Button @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Button();
            this.Save = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "Save";
            @__ctrl.Text = "Save";
            ((System.Web.UI.IAttributeAccessor)(@__ctrl)).SetAttribute("class", "btn btn-default pull-right margin10");
            ((System.Web.UI.IAttributeAccessor)(@__ctrl)).SetAttribute("style", "height: 26px");
            @__ctrl.Click -= new System.EventHandler(this.Save_Click);
            @__ctrl.Click += new System.EventHandler(this.Save_Click);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void @__BuildControlTree(global::TillidInvoice.Custom_WebParts.CustomerCreation.CustomerCreation @__ctrl) {
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl(@"
 

<div class=""container-fluid"">

            <div class=""row"">

               <div class=""col-md-12"">

                  <div class=""box incomecol"">

                     <h3 class=""accord"">Customer</h3>

                     <div class=""row"">

                        <div class=""col-md-3"">

                        <div class=""form-group"">

                              <label>Name</label>

                             "));
            global::System.Web.UI.WebControls.TextBox @__ctrl1;
            @__ctrl1 = this.@__BuildControltxtName();
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl(@"

                           </div>

                        </div>
                      
                   

                        <div class=""col-md-3"">
                           <div class=""form-group"">
                              <label>Status</label>
                              <br>
                               "));
            global::System.Web.UI.WebControls.RadioButtonList @__ctrl2;
            @__ctrl2 = this.@__BuildControlRadioStatus();
            @__parser.AddParsedSubObject(@__ctrl2);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl(@"
                         
                           </div>
                        </div>

                        <div class=""col-md-3"">
                           <div class=""form-group"">
                              <label>Address</label>
                               "));
            global::System.Web.UI.WebControls.TextBox @__ctrl3;
            @__ctrl3 = this.@__BuildControltxtAddress();
            @__parser.AddParsedSubObject(@__ctrl3);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl(@"
                              
                           </div>
                        </div>
                     </div>

                     <div class=""row"">
                        <div class=""col-md-3"">
                           <div class=""form-group"">
                              <label>Email</label>
                               "));
            global::System.Web.UI.WebControls.TextBox @__ctrl4;
            @__ctrl4 = this.@__BuildControltxtEmail();
            @__parser.AddParsedSubObject(@__ctrl4);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl(@"
                              
                           </div>
                        </div>

                        <div class=""col-md-3"">
                           <div class=""form-group"">
                              <label>Website</label>
                               "));
            global::System.Web.UI.WebControls.TextBox @__ctrl5;
            @__ctrl5 = this.@__BuildControltxtWebs();
            @__parser.AddParsedSubObject(@__ctrl5);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl(@"
                              
                           </div>
                        </div>

                        <div class=""col-md-3"">
                           <div class=""form-group"">
                              <label>Phone</label>
                               "));
            global::System.Web.UI.WebControls.TextBox @__ctrl6;
            @__ctrl6 = this.@__BuildControltxtPhone();
            @__parser.AddParsedSubObject(@__ctrl6);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl(@"
                             
                           </div>
                        </div>

                        <div class=""col-md-3"">
                           <div class=""form-group"">
                              <label>Fax</label>
                               "));
            global::System.Web.UI.WebControls.TextBox @__ctrl7;
            @__ctrl7 = this.@__BuildControltxtFax();
            @__parser.AddParsedSubObject(@__ctrl7);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl(@"
                              
                           </div>
                        </div>
                     </div>

                     <div class=""row"">
                        <div class=""col-md-6"">
                           <div class=""form-group"">
                              <label>Description</label>
                               "));
            global::System.Web.UI.WebControls.TextBox @__ctrl8;
            @__ctrl8 = this.@__BuildControltxtDescription();
            @__parser.AddParsedSubObject(@__ctrl8);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n                             \r\n                           </div>\r\n             " +
                        "           </div>\r\n                     </div>\r\n\r\n                     <div clas" +
                        "s=\"row\">\r\n                        <div class=\"col-md-12 \">\r\n\r\n                  " +
                        "          "));
            global::System.Web.UI.WebControls.Button @__ctrl9;
            @__ctrl9 = this.@__BuildControlSave();
            @__parser.AddParsedSubObject(@__ctrl9);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl(@"
                           
                           <button type=""button"" class=""btn btn-default pull-right margin10"">Save Client &amp; Create another</button>
                            
                           
                            
                        </div>
                     </div>

                  </div>

               </div>

            </div>

       </div>
   
              
      


"));
        }
        
        private void InitializeControl() {
            this.@__BuildControlTree(this);
            this.Load += new global::System.EventHandler(this.Page_Load);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected virtual object Eval(string expression) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected virtual string Eval(string expression, string format) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression, format);
        }
    }
}
