   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Client.ViewModelsClient.ViewModels  5   	        Client.Views.NewLaunchView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Client.ViewModels     5   	     � Title$  NewLaunchView��5   	   $	��768��6   $
��1024��6,    � 
ResizeMode$ CanMinimize=�69    � DataContext 5      *   $Client.ViewModels.NewLaunchViewModel  5   
    � 	Resources 5         CheckBoxRadioButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Orientation	 d� 	IsChecked
 �� RelativeSource �� Mode��%6  &	        �� 5   
   " 	�61   .�5      ��  � �� 5      �� 5      " 	�6&   .R�5      �� $ 
Horizontal=�6%   .+�5      � .+�5   "   �� 	 6+   �� *	IsChecked+
 �� *TemplatedParent+$ TwoWay=�5      �� 5      #��z��6(   5      5      5      5      5      .��5"      ]� .+�5$   
   �� 
���   �$	��0.5q�6%   $	��Top=�6;   ._�5&      �� $	��Top=�6   $��Center=�6)   $l��fПанель управления (Users | Parameters & Characteristics | Models | Launches | Compare)��6F   5'      �� 5*   
   
���   �$	��0.5q�6%   $��Bottom=�6;   ._�5+      A�  A� Columns$ 2��6   .+�5,      �� -   5        $��Help to fill in��5,      $��100, 10, 100, 10q�63   6M   �� 5-      -   5        $��
Run launch��5-      $��100, 10, 100, 10q�6.    �� 	IsDefault$
 True��6a   5.      5/      �� 52   
   
���   �$	��0.5q�6%   $
��Left=�6;   ._�53      �� $	��345��6   .+�54      �� $��Selected Characteristics��6   $��Center=�6;   $��0,5,0,0q�6_   &   System.Windows.Controls.DataGrid  55      -   5          Name$ SelectedCharacteristics��55      $	��290��6<      AutoGenerateColumns$ False��6I      CanUserAddRows$ False��6�      CanUserDeleteRows$ False��6�   ��6e   �� *SelectedCharacteristics+   Columns 56      0  *System.Windows.Controls.DataGridTextColumn  57      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6-      SortDirection 	Ascending6P      MinWidth$ 30Q�6j      
IsReadOnly$
 True��6x   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *Id+6x     58      $
 Name��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6T   $
 True��6^    6;   �� *Name+6^   4  .System.Windows.Controls.DataGridCheckBoxColumn  59      $ 
IsSelected��61   $ * 6d   $
 True��6n    6E   �� *
IsSelected+   ElementStyle 5:      �� 5;   "   " ��6(   .�5<   &   -   5        5=   #   5?      4  .System.Windows.Controls.DataGridTemplateColumn  5@      $ Models��61   $ * 6A   $
 True��6K      CellTemplate 5A      �� 5B   "   .R�5C   &   o� $
��Left=�6+   .@�5D   *   m� $��Menu Models��63   ��6H   �� *DataContext.MenuModels+
 ��  �� AncestorType" ���5E   .   �� 5F   2   .R�5G   6   �� ��6?   �� *Name+	 6X   �� *	IsChecked+5H   3   5J   +   5K   '   5L   #   5N      5P      �� 5Q      $��All Characteristics��6   $��Center=�66   $��0,25,0,0q�6Z     5R      -   5        $ AllCharacteristics��5R      $	��290��67   $ False��6D   $ False��6�   $ False��6�   ��6`   �� *Characteristics+ 5S        5T      $ Id��6-    	Ascending6P   $ 30Q�6j   $
 True��6x    69   �� *Id+6x     5U      $
 Name��6-   $ * 6T   $
 True��6^    6;   �� *Name+6^     5V      $ 
IsSelected��61   $ * 6d   $
 True��6n    6E   �� *
IsSelected+ 5W      �� 5X   "   " ��6(   .�5Y   &   -   5        5Z   #   5\      5^      5_      5`      �� 5c   
   
���   �$	��0.5q�6%   ._�5d      �� $	��345��6   .+�5e      �� $��Selected Parameters��6   $��Center=�66   $��0,5,0,0q�6Z     5f      -   5        $ SelectedParameters��5f      $	��290��67   $ False��6D   $ False��6�   $ False��6�   ��6`   �� *SelectedParameters+ 5g        5h      $ Id��6-    	Ascending6P   $ 30Q�6j   $
 True��6x    69   �� *Id+6x     5i      $
 Name��6-   $ * 6T   $
 True��6^    6;   �� *Name+6^     5j      $ 
IsSelected��61   $ * 6d   $
 True��6n    6E   �� *
IsSelected+ 5k      �� 5l   "   " ��6(   .�5m   &   -   5        5n   #   5p        5q      $ Value��6-   $ * 6V    6<   �� *Value+6V   5s      �� 5t      $��All Parameters��6   $��Center=�61   $��0,25,0,0q�6U     5u      -	   5        $ AllParameters��5u      $	��290��62   $ False��6?   $ False��6~   $ False��6�   ��6[   �� *
Parameters+ 5v        5w      $ Id��6-    	Ascending6P   $ 30Q�6j   $
 True��6x    69   �� *Id+6x     5x      $
 Name��6-   $ * 6T   $
 True��6^    6;   �� *Name+6^     5y      $ 
IsSelected��61   $ * 6d   $
 True��6n    6E   �� *
IsSelected+ 5z      �� 5{   "   " ��6(   .�5|   &   -
   5        5}   #   5      5�      5�      5�      �� 5�   
   
���   �$	��0.5q�6%   $��Right=�6;   ._�5�      �� $	��334��6   .+�5�      �� $#��Additional modelling settings��6   $��Center=�6@   $��0,5,0,10q�6d   o� 5�      $��Center=�6   .@�5�      m� $��Parameter for iteration��6   ��6@   �� *SelectedParameters+��5�      �� 5�      .R�5�   "   	�  	� 	GroupName$ ParamsForIteration��6G   #��[  6f   ��6.   �� *Name+6f   5�      5�      5�      �� 5�      $ 
Horizontal=�6   $��Center=�66   $��	0,20,0,20q�6S   .+�5�      �� $��Decision Accuracy��6   $��0,0,25,0q�68   �� 5�      -   5         ��Name$ DecisionAccuracyBox��5�      $	��100��6;   $��Center=�6G   $��Right=�6b   6~   �� 5�       J� IsHitTestVisible$ False��6    $��Value��69   $��Center=�6F   $��Center=�6a   $��
-100,0,0,0q�6~   
���������5�      �� 5�      " ��6$   .�5�   "   ��  � y�$ 	Collapsed=�6?    �� Triggers 5�   "   �� 5�   &     �� Binding  62   �� *Text+! �� ElementName$! DecisionAccuracyBox��" �� Value"  6l   .a�5�   *   ��  � y�$ Visible=�6G   5�   '   5�      5�      5�      o� 5�      $��Center=�6   .@�5�      m� $��Optimization Algorithm��6   .@�5�      	� -   5        # 	�Name$# ConstantStep��5�   &   $��ConstantStep��6<   #��[  6S   6�   	� 5�      -   5        $# SmartConstantStep��5�   &   $��SmartConstantStep��6A   #��[  6]   6�   	� 5�      -   5        $# BinarySearch��5�   &   $��BinarySearch��6<   #��[  6S   6�   	� 5�      -   5        $# SmartBinarySearch��5�   &   $��SmartBinarySearch��6A   #��[  6]   6�   	� 5�      -   5        $# GoldenSection��5�   &   $��GoldenSection��6=   #��[  6U   6�   	� 5�      -   5        $# SmartGoldenSection��5�   &   $��SmartGoldenSection��6B   #��[  6_   6�   5�      5�      �� 5�      $��Center=�6   .+�5�      �� -   5        $ 	StepValue��5�      $y�	Collapsed=�61   $	��200��6H   $��Center=�6T   $��0,10,0,5q�6o   6�   �� 5�      $ False��6    $��Step Value*��69   $��Center=�6L   $��Center=�6g   $��	0,-30,0,0q�6�   
���������5�      �� 5�      " ��6$   .�5�   "   ��  � y�$ 	Collapsed=�6?    5�   "   ^� 5�   &   $ ^� 
Conditions$ 5�   *   �� 5�   .   % �� Binding% 68   �� *
Visibility+$! 	StepValue��& �� Value& Visible6n   �� 5�   .   % 68   �� *Text+$! 	StepValue��&  6h   .0�5�   *   ��  � y�$ Visible=�6G   5�   '   5�      5�      �� 5�      -   5        $ MaxFreqOfDataGen��5�      $y�	Collapsed=�68   $	��200��6O   $��Center=�6[   $��0,5,0,5q�6v   6�   �� 5�      $ False��6    $'��!Max Frequency of Data Generation*��69   $��Center=�6b   $��Center=�6}   $��	0,-30,0,0q�6�   
���������5�      �� 5�      " ��6$   .�5�   "   ��  � y�$ 	Collapsed=�6?    5�   "   ^� 5�   &   $ 5�   *   �� 5�   .   % 68   �� *
Visibility+$! MaxFreqOfDataGen��& Visible6u   �� 5�   .   % 68   �� *Text+$! MaxFreqOfDataGen��&  6o   .0�5�   *   ��  � y�$ Visible=�6G   5�   '   5�      5�      �� 5�      -   5        $ 
NumOfIters��5�      $y�	Collapsed=�62   $	��200��6I   $��Center=�6U   $��0,5,0,5q�6p   6�   �� 5�      $ False��6    $��Number of Iterations*��69   $��Center=�6V   $��Center=�6q   $��	0,-30,0,0q�6�   
���������5�      �� 5�      " ��6$   .�5�   "   ��  � y�$ 	Collapsed=�6?    5�   "   ^� 5�   &   $ 5�   *   �� 5�   .   % 68   �� *
Visibility+$! 
NumOfIters��& Visible6o   �� 5�   .   % 68   �� *Text+$! 
NumOfIters��&  6i   .0�5�   *   ��  � y�$ Visible=�6G   5�   '   5�      5�      �� 5�      -   5        $ MaxNumOfIters��5�      $y�	Collapsed=�65   $	��200��6L   $��Center=�6X   $��0,5,0,5q�6s   6�   �� 5�      $ False��6    $��Max Number of Iterations��69   $��Center=�6Y   $��Center=�6t   $��	0,-30,0,0q�6�   
���������5�      �� 5�      " ��6$   .�5�   "   ��  � y�$ 	Collapsed=�6?    5�   "   ^� 5�   &   $ 5�   *   �� 5�   .   % 68   �� *
Visibility+$! MaxNumOfIters��& Visible6r   �� 5�   .   % 68   �� *Text+$! MaxNumOfIters��&  6l   .0�5�   *   ��  � y�$ Visible=�6G   5�   '   5�      5�      �� 5�      -   5        $ Accuracy��5�      $y�	Collapsed=�60   $	��200��6G   $��Center=�6S   $��0,5,0,0q�6n   6   �� 5�      $ False��6    $��Accuracy��69   $��Center=�6I   $��Center=�6d   $��	0,-20,0,0q�6�   
���������5�      �� 5�      " ��6$   .�5�   "   ��  � y�$ 	Collapsed=�6?    5�   "   ^� 5�   &   $ 5   *   �� 5  .   % 68   �� *
Visibility+$! Accuracy��& Visible6m   �� 5  .   % 68   �� *Text+$! Accuracy��&  6g   .0�5  *   ��  � y�$ Visible=�6G   5  '   5     5	     5
     5     5     5     5     