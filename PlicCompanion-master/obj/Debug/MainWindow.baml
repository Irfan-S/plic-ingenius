   M S B A M L   `   `   `  ����H  DPlicCompanion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:PlicCompanionPlicCompanion  5   	       PlicCompanion.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:PlicCompanion     5   	   -   5          � Title$  PlicCompanion��5   	   $	��450��6   $	��800��6,    � WindowStartupLocation$ CenterScreen=�68   
�������$2��,/PlicCompanion;component/Res/font/#Helvetica)�6p    � 
ResizeMode$ CanMinimize=�6�   .��5      � .+�5   
   �� $��Welcome to Posturect��6   $
��Left=�6/   $��	15,15,0,0q�6J   $	��Top=�6]   $2��,/PlicCompanion;component/Res/font/#Helvetica)�6v   $��24(�6�    � Triggers 5      :� 5       :� RoutedEvent$ Label.Loaded��6   .[�5      �� .��5      �� .��5      W�  �� TargetProperty$ Opacity�6.    W� From$ 0X�6R   	 W� To$ 1X�6[    g� Duration$ 0:0:2D�6b   	 g� FillBehavior$	 HoldEnd=�6s   5      5      5      5      �� 5   
   $��Posture:��6   $
��Left=�6#   $��314,149,0,0q�6>   $	��Top=�6S   $2��,/PlicCompanion;component/Res/font/#Helvetica)�6k   $��15(�6�    5      :� 5      $ Label.Loaded��6   .[�5      �� .��5      �� .��5      W� $ Opacity�6.   $ 0X�6R   $ 1X�6[   $ 0:0:2D�6b   $	 HoldEnd=�6s   5      5      5       5"      �� 5#   
   -   5        
 ��Name$	
 pos��5#      $��-��6   $
��Left=�6)   $��380,144,0,0q�6D   $	��Top=�6Y   $2��,/PlicCompanion;component/Res/font/#Helvetica)�6q   $��20(�6�   $��37��6�   $	��335��6�    5$      :� 5%      $ Label.Loaded��6   .[�5&      �� .��5'      �� .��5(      W� $ Opacity�6.   $ 0X�6R   $ 1X�6[   $ 0:0:2D�6b   $	 HoldEnd=�6s   5)      5*      5+      5-      �� 5.   
   -   5         ��Name$ F0��5.      $��F0��6   $
��Left=�6*   $��
690,10,0,0q�6E   $	��Top=�6Y   $��35��6q   $��30��6|   $y�Hidden=�6�   �� 5/   
   -   5        $ F1��5/      $��F1��6   $
��Left=�6*   $��
739,10,0,0q�6E   $	��Top=�6Y   $��35��6q   $��30��6|   $y�Hidden=�6�   �� 50   
   -   5        $

 desc��50      $g��aConnectivity to the Plicinc device could not be established. Please connect/reconnect your device��6   $
��Left=�6�   $��113,186,0,0q�6�   $	��Top=�6�   $2��,/PlicCompanion;component/Res/font/#Helvetica)�6�   $��Center=�6   51      :� 52      $ Label.Loaded��6   .[�53      �� .��54      �� .��55      W� $ Opacity�6.   $ 0X�6R   $ 1X�6[   $ 0:0:2D�6b   $	 HoldEnd=�6s   56      57      58      5:      �� 5;   
   $|��vPosturect™ provides simple ways to help you form and maintain better posture habits while using your smart devices. ��6   $
��Left=�6�   $��	36,76,0,0q�6�   $	��Top=�6�   $2��,/PlicCompanion;component/Res/font/#Helvetica)�6�    5<      :� 5=      $ Label.Loaded��6   .[�5>      �� .��5?      �� .��5@      W� $ Opacity�6.   $ 0X�6R   $ 1X�6[   $ 0:0:2D�6b   $	 HoldEnd=�6s   5A      5B      5C      5E      �� 5F   
   -   5        $
 anal��5F      $��Analysis��6   $
��Left=�62   $��
36,364,0,0q�6M   $	��Top=�6a   $��60��6y   $2��,/PlicCompanion;component/Res/font/#Helvetica)�6�   $��20��6�   6�   �� 5G   
   -   5        $
 exit��5G      $
��Exit��6   $
��Left=�6.   $��730,378,0,0q�6I   $	��Top=�6^   $��35��6v   $2��,/PlicCompanion;component/Res/font/#Helvetica)�6�   $��18��6�   ���	#FFFF37376�   �� 5H   
   -   5        $	 con��5H      $��Disconnected��6   $
��Left=�65   $��
690,45,0,0q�6P   $	��Top=�6d   $��84��6|   $��20��6�   6�   �� 5I   
   -	   5        $ Options��5I      $��Options��6"   $
��Left=�64   $��113,364,0,0q�6O   $	��Top=�6d   $��60��6|   $��20��6�   $2��,/PlicCompanion;component/Res/font/#Helvetica)�6�   6�   5K      5L      