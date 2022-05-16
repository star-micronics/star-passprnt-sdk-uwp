************************************************************
      Star PassPRNT Ver 2.3.0 SDK (UWP)
         Readme_Jp.txt                  スター精密（株）
************************************************************

 1. 概要
 2. 内容
 3. 適用
 4. 著作権
 5. 変更履歴

==========
 1. 概要
==========

  本パッケージは、UWP(Universal Windows Platform)のStar PassPRNT専用SDKです。
  “PassPRNT”とは、外部アプリケーション（以降、”連携アプリ”とする）と
  スターデバイス（以降、”デバイス”とする）の間に配置するアプリケーションです。
  このアプリケーションは、連携アプリからレシートのデザイン、用紙幅、その他に
  関連する情報を受け取ると印字データに変換して、プリンタに送信を行います。
  よって、連携アプリはプリンタとの通信に関わる部分の設計-開発の必要がありません。
  またプリンタステータスの監視や印刷成否の判定も行うため、連携アプリは
  それらの実施も不要となります。

  またレシートデザインは、HTMLレイアウトに対応しているため、
  デバイス独自のコマンド仕様を理解する必要はありません。

  詳細は別紙ドキュメントファイルを参照ください。


==========
 2. 内容
==========

  PassPRNT_Ver2.3.0_UWP_SDK_20211029
  |
  | Readme_En.txt                       // リリースノート(英語)
  | Readme_Jp.txt                       // リリースノート(日本語)
  | SoftwareLicenseAgreement.pdf        // ソフトウエア使用許諾書(英語)
  | SoftwareLicenseAgreement_jp.pdf     // ソフトウエア使用許諾書(日本語)
  | UsersManual_UWP.url                 // User Manualへのショートカット
  +- Samples                            // Windows UWP用サンプルプログラム


=============
 3. 適用
=============
  ■ 対象OS
   Windows 10 Build 2004以降
   Windows 11

  ■ 対象ソフトウェア
   PassPRNT Ver2.5.0

  ■ 対象プリンタモデル
   ◇ プリンタモデル (F/W ver)
       SM-L200         (Ver 1.1以降 - StarPRNT mode)
       SM-S210i *1     (Ver 3.0以降 - StarPRNT mode)
                       (Ver 2.5以降 - ESC/POS mode)
       SM-S220i *2     (Ver 3.0以降 - StarPRNT mode)
                       (Ver 2.1以降 - ESC/POS mode)
       SM-S230i *2     (Ver 1.0以降 - StarPRNT mode)
                       (Ver 1.0以降 - ESC/POS mode)
       SM-L300         (Ver 1.0以降 - StarPRNT mode)
       SM-T300i/T300DB (Ver 3.0以降 - StarPRNT mode)
                       (Ver 2.5以降 - ESC/POS mode)
       SM-T400i        (Ver 3.0以降 - StarPRNT mode)
                       (Ver 2.5以降 - ESC/POS mode)
       TSP650II        (Ver 2.1以降)
       TSP700II        (Ver 5.1以降)
       TSP800II        (Ver 2.1以降)
       TSP100IIIBI     (Ver 1.0以降)
       TSP100IIIW      (Ver 1.4以降)
       TSP100IIILAN    (Ver 1.3以降)
       TSP100IV        (Ver 1.0以降)
       FVP10           (Ver 2.0以降)
       BSC10    *2     (Ver 1.0以降)
       mPOP            (Ver 1.0.1以降)
       mC-Print2       (Ver 1.0以降)
       mC-Print3       (Ver 1.0以降)

       *1-JPモデルのみ
       *2-欧米モデルのみ

   ◇ 対応インターフェース
       Bluetooth: TSPシリーズ (IFBD-HB03/HB04 Ver 1.0.0以上)
                : ポータブルプリンタシリーズ
                : mPOP, mC-Print2, mC-Print3
       Ethernet : TSPシリーズ, FVP10, BSC10 (IFBD-HE05/HE06 Ver 1.0.1以上)
                : mC-Print2, mC-Print3

===========
 4. 著作権
===========

  スター精密（株）Copyright 2017 - 2021


==========================
 5. Star PassPRNT 更新履歴
==========================
 Ver 2.3.0
  2021/10/29  : TSP100IVに対応
                ブザー(BU01), メロディースピーカー(mC-Sound)のサポートを追加

 Ver 2.2
  2020/01/23  : Webダウンロード印刷に対応 ('url'クエリ)。
                PassPRNTアプリへの印刷データの受け渡し方法をiOS/Android版Star PassPRNTと同等に変更。
