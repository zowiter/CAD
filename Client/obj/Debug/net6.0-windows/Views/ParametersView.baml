   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Client.ViewsClient.Views  5      !    Client.Views.ParametersView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Client.Views     5      .��5	      � .+�5   
   �� $	��200��6   $��22��6   $��25,46,740,700q�6*   ��6A   �� *ParametersModel.IdFilter+6m   �� 5   
   $
��Left=�6   $��20��6/   $��
109,21,0,0q�6;   $
��Wrap=�6O   $��Parameter Id��6c   $	��Top=�6w   $	��100��6�   �� 5   
   $	��200��6   $��22��6   $��225,46,494,700q�6*   ��6B   �� *ParametersModel.NameFilter+�� 5   
   $
��Left=�6   $��20��6/   $��
357,21,0,0q�6;   $
��Wrap=�6O   $
��Name��6c   $	��Top=�6o   $��44��6�   �� 5   
   $	��200��6   $��22��6   $��352,45,172,699q�6+     �� SelectedItem  6C   �� *!ParametersModel.ValueTypeFilter+.@�5      �� int6   �� 5      double6    �� 5      bool6   5      �� 5   
   $	��200��6   $��22��6   $��580,45,-49,700q�6+     6C   �� *ParametersModel.ModelsFilter+.@�5      �� 	Booksim6!   �� 5      Newxim6    �� 5      DEC96   �� 5      TOPAZ6   �� 5      
gpNocSim6"   5      �� 5   
   $
��Left=�6   $��20��6/   $��
569,21,0,0q�6;   $
��Wrap=�6O   $��
Value Type��6c   $	��Top=�6u   $��88��6�   �� 5   
   $
��Left=�6   $��20��6/   $��
800,21,0,0q�6;   $
��Wrap=�6O   $��Model��6c   $	��Top=�6p   $��66��6�   �� 5   
   $'��!Применить фильтры��6   $	��130��6-   $��25��69   $��-20,-550,0,0q�6E   ��6[   �� *FilterParametersCommand+6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
paramsList��5         AutoGenerateColumns$ False��6Y   $��	0,158,0,0q�6u   ��6'   �� *ParametersModel.ParamList+   Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *id+6H     5"      $
 Name��6%   $ * 6L    63   �� *name+6L     5#      $ 
Value Type��6%   $ * 6W    69   �� *	valueType+6W     5$      $ Model��6%   $ * 6O    64   �� *models+6O   5&      5'      5(      