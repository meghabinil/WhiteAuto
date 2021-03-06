﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestStack.White.UIItems.Finders;

namespace Common.Ui
{
  public class UiItems
  {
    #region Mars items

    public const string MarsProcessName = "MscMars";

    public const string MarsMainWindowName = "EasyGuiWindow";

    #endregion

    #region ProcessTouch items

    public const string MantaProcessname = "FOSS.ProcessTouch.Main";

    public const string MantaWindowtitle = "ProcessTouch";

    public static SearchCriteria MantaStartStopButton = SearchCriteria.ByText("StatusBarStartPauseButton");

    public const string MantaLolipopButtonName = "StatusBarBatchControlButton";

    #endregion

    #region Matilde Items

    public const string MatildeMainWindowName = "ISI Nova";

    public const string MatildeProcessName = "FOSS.Nova.UI.Matilde.Core";

    public const string ServiceViewProbeAdjustmentButton = "ServiceViewProbeAdjustmentButton";

    public const string ServiceViewStartMotorDriftTestButton = "ServiceViewStartMotorDriftTestButton";

    public const string MenuBarInstrumentStateText = "MenuBarInstrumentStateText";

    public const string InstrumentListComboBox = "InstrumentListComboBox";

    #endregion

    #region Advanced UI items

    public const string AdvancedUiProcessName = "FOSS.Nova.UI.Advanced.Core";

    public static SearchCriteria AdvancedUiStartStopButton = SearchCriteria.ByText("StatusBarStartButton");

    public const string AdvancedSelectProductDialogName = "SelectProductPopup";

    public static SearchCriteria AdvancedProductsList = SearchCriteria.ByText("SelectProductListBox");

    #endregion

    #region Metrohm UI items

    public const string MetrohmProcessName = "FOSS.Nova.UI.Metrohm.Core";

    #endregion

    #region Mini UI Items

    public const string MiniUiProcessName = "FOSS.Nova.UI.MiniTouch.Core";

    public static SearchCriteria MiniUiStartStopButton = SearchCriteria.ByAutomationId("MenuBarStartStopButton");

    public const string MiniUiSelectProductsDialogName = "PopupSelectProductsWindow";

    public static SearchCriteria MiniUiProductsList = SearchCriteria.ByAutomationId("ProductListView");

    #endregion

    #region Common Items

    public const string BenchMainWindowName = "MainWindow";

    public const string SelectProductButtonName = "StatusBarSelectProductButton";

    public const string MessageBoxPopup = "MessageBoxPopup";

    public const string MessageBoxPopupYesButton = "PopupLeftButton";

    public const string MessageBoxPopupNoButton = "PopupLeftButton";

    #endregion

  }
}
