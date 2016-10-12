﻿using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using UIKit;
using FormsToolkit.iOS;
using developer.open.space.iOS;
using developer.open.space.Clients.Views.Cells;

[assembly:ExportRenderer(typeof(TextViewValue), typeof(TextViewValue1Renderer))]
namespace developer.open.space.iOS
{
    public class TextViewValue1Renderer : TextCellRenderer
    {
        public static void Init()
        {
            var test = DateTime.UtcNow;
        }

        public override UITableViewCell GetCell (Cell item, UITableViewCell reusableCell, UITableView tv)
        {

            var tvc = reusableCell as CellTableViewCell;
            if (tvc == null) {
                tvc = new CellTableViewCell (UITableViewCellStyle.Value1, item.GetType().FullName);
            }
            tvc.Cell = item;
            var cell = base.GetCell(item, tvc, tv);
            cell.SetDisclosure(item.StyleId);
            return cell;
        }
    }
}

