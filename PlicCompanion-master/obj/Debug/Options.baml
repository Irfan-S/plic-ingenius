   M S B A M L   `   `   `  ����X  TXceed.Wpf.Toolkit, Version=3.8.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4P:clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.ToolkitXceed.Wpf.Toolkit  5   	   H DPlicCompanion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:PlicCompanionPlicCompanion 5   	      PlicCompanion.Options   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4xctk)http://schemas.xceed.com/wpf/xaml/toolkit   5   	   HwpfTool:clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.Toolkit   5   	   'localclr-namespace:PlicCompanion   5   	   -   5          � Title$  Options��5
   	   $	��551��6   $	��450��6&   $2��,/PlicCompanion;component/Res/font/#Helvetica)�62    � 
ResizeMode$ NoResize=�6l    � WindowStartupLocation$ CenterScreen=�6�   .��5      � .+�5   
   �� $��Run at startup:��6   $
��Left=�6*   $��	20,24,0,0q�6E   $	��Top=�6X   $��31��6p   $	��127��6|   $��18(�6�   �� 5   
   -   5         ��Name$ runStart��5      $�� ��6%   $
��Left=�60   $��
213,33,0,0q�6K   $	��Top=�6_   $��14��6w   $��15��6�    � LayoutTransform 5      �� 5       �� ScaleX$	 1.3Q�6!    �� ScaleY$	 1.3Q�6.   5      �� 5   
   $��Minimise to tray:��6   $
��Left=�6,   $��	20,74,0,0q�6G   $	��Top=�6Z   $��31��6r   $	��142��6~   $��18(�6�   �� 5   
   -   5        $ trayMin��5      $�� ��6$   $
��Left=�6/   $��
213,84,0,0q�6J   $	��Top=�6^   $��14��6v   $��15��6�    5      �� 5      $	 1.3Q�6!   $	 1.3Q�6.   5      �� 5   
   $��
Idle Timer��6   $
��Left=�6'   $	��162��6B   $��
20,201,0,0q�6O   $	��Top=�6c   $	��390��6{   .��5      � $��0,0,-1.6,-1q�6   .+�5      �� $��Enable Timer:��6   $
��Left=�60   $��4,12,0,0q�6K   $	��Top=�6]   $��31��6u   $	��142��6�   $��18(�6�   �� 5      -   5        $ 
timrEnable��5      $�� ��6/   $
��Left=�6:   $��
188,19,0,0q�6U   $	��Top=�6i   $��14��6�   $��15��6�    5      �� 5      $	 1.3Q�6)   $	 1.3Q�66   5      �� 5       $��Time Interval:��6   $
��Left=�61   $��4,58,0,0q�6L   $	��Top=�6^   $��18(�6v   %   Xceed.Wpf.Toolkit.IntegerUpDown  5!      -   5          Name$
 hour��5!   %   �   �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Value$ 1X�63   $��
193,67,0,0q�6=   	   Maximum$	 12X�6Q   
   Minimum$
 00X�6^   $��21��6k   $	��Top=�6w   $
��Left=�6�   $��42��6�     5"      -   5        $	 min��5"   (   $ 1X�65   $��
253,67,0,0q�6?   $	 60X�6S   $
 01X�6`   $
��Left=�6m   $��40��6�   $��21��6�   $	��Top=�6�   �� 5#      $��H��6   $
��Left=�6$   $��
235,64,0,0q�6?   $	��Top=�6S   �� 5$      $��M��6   $
��Left=�6$   $��
293,64,0,0q�6?   $	��Top=�6S   �� 5%      $��Audio Alert Only:��6   $
��Left=�64   $��	4,106,0,0q�6O   $	��Top=�6b   $��31��6z   $	��142��6�   $��18(�6�   �� 5&      -   5        $ tmrAudioOnly��5&      $�� ��61   $
��Left=�6<   $��188,115,0,0q�6W   $	��Top=�6l   $��14��6�   $��15��6�    5'      �� 5(      $	 1.3Q�6)   $	 1.3Q�66   5*      5+      5,      �� 5-   
   $��Sounds:��6   $
��Left=�6"   $��
20,130,0,0q�6=   $	��Top=�6Q   $��31��6i   $	��142��6u   $��18(�6�   �� 5.   
   -   5        $ audioEn��5.      $�� ��6$   $
��Left=�6/   $��213,140,0,0q�6J   $	��Top=�6_   $��14��6w   $��15��6�    5/      �� 50      $	 1.3Q�6!   $	 1.3Q�6.   52      �� 53   
   -	   5         ��Name$ apply��53      $
��Save��6    $
��Left=�6/   $��
64,445,0,0q�6J   $	��Top=�6^   $��83��6v   $��31��6�   6�   �� 54   
   -
   5        $ cancel��54      $��Cancel��6!   $��296,445,0,0q�62   $	��Top=�6G   $��31��6_   $
��Left=�6k   $��83��6�   6�   56      57      