************************************************************
      Star PassPRNT Ver 2.3.0 SDK (UWP)
         Readme_En.txt             Star Micronics Co., Ltd. 
************************************************************

 1. Overview
 2. Contents
 3. Scope
 4. Copyright
 5. Release History


=============
 1. Overview
=============

   This package contains SDK for Star PassPRNT UWP(Universal Windows Platform).
   "PassPRNT" is an application intervening outer applications (hereinafter 
   called "Coordinating App" and Star Device (hereinafter called "Device").
   This App transfers to the printer the print data converted from all Coordinating
   App information including receipt design, paper width and other related data.
   Therefore the Coordinating App needs no designing or development to establish
   communication with the printer.
   Similarly printer status and print result are monitored as well so that 
   Coordinating App is not required on such control.

   Receipt design put out of this system is supported by HTML layout, so there is
   no need to understand the device unique command specifications.
   Please refer to document including this package for details.

=============
 2. Contents
=============

  PassPRNT_Ver2.3.0_UWP_SDK_20211029
  |
  | Readme_En.txt                       // Release Note(English)
  | Readme_Jp.txt                       // Release Note(Japanese)
  | SoftwareLicenseAgreement.pdf        // Software License Agreement(English)
  | SoftwareLicenseAgreement_jp.pdf     // Software License Agreement(Japanese)
  | UsersManual_UWP.url                 // Shortcut to User Manual
  +- Samples                            // Windows UWP project file for sample program


=================
 3. Scope
=================
  [OS]
    Windows 10 Build 2004 or later
    Windows 11

  [Software]
    PassPRNT Ver2.5.0

  [Printer Model]
    SM-L200         (Ver 1.1 or later - StarPRNT mode)
    SM-S210i *1     (Ver 3.0 or later - StarPRNT mode)
                    (Ver 2.5 or later - ESC/POS mode)
    SM-S220i *2     (Ver 3.0 or later - StarPRNT mode)
                    (Ver 2.1 or later - ESC/POS mode)
    SM-S230i *2     (Ver 1.0 or later - StarPRNT mode)
                    (Ver 1.0 or later - ESC/POS mode)
    SM-L300         (Ver 1.0 or later - StarPRNT mode)
    SM-T300i/T300DB (Ver 3.0 or later - StarPRNT mode)
                    (Ver 2.5 or later - ESC/POS mode)
    SM-T400i        (Ver 3.0 or later - StarPRNT mode)
                    (Ver 2.5 or later - ESC/POS mode)
    TSP650II        (Ver 2.1 or later)
    TSP700II        (Ver 5.1 or later)
    TSP800II        (Ver 2.1 or later)
    TSP100IIIBI     (Ver 1.0 or later)
    TSP100IIIW      (Ver 1.4 or later)
    TSP100IIILAN    (Ver 1.3 or later)
    TSP100IV        (Ver 1.0 or later)
    FVP10           (Ver 1.3 or later)
    BSC10    *2     (Ver 1.0 or later)
    mPOP            (Ver 1.0.1 or later)
    mC-Print2       (Ver 1.0 or later)
    mC-Print3       (Ver 1.0 or later)

     *1-JP model only
     *2-US EU model only

  [Interface]
    Bluetooth: TSP series (IFBD-HB03/HB04 Ver 1.0.0 or later)
             : Portable printers
             : mPOP, mC-Print2, mC-Print3
    Ethernet : TSP series, FVP10, BSC10 (IFBD-HE05/HE06 Ver 1.0.1 or later)
             : mC-Print2, mC-Print3


==============
 4. Copyright
==============

  Copyright 2017 - 2021 Star Micronics Co., Ltd. All rights reserved.


=================================
 5. Star PassPRNT Release History
=================================

 Ver 2.3.0
  2021/10/29  : Added TSP100IV support.
                Added Buzzer (BU01) and  Melody Speaker (mC-Sound) support.

 Ver 2.2
  2020/01/23 : Added Web Download Print function ('url' query).
  
               Changed the specifications(How to pass data to PassPRNT app)
               to be equivalent to iOS / Android version.
