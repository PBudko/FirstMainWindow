   M S B A M L   `   `   `  ����J  FFirstMainWindow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:FirstMainWindow.SecondViewModelFirstMainWindow.SecondViewModel  5   	   3    -FirstMainWindow.SecondView.AddSotrudnicWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:FirstMainWindow.SecondViewModel     5   	     � Title$  AddSotrudnicWindow��5   	   $	��300��6$   $	��400��61    � DataContext 5	      :   4FirstMainWindow.SecondViewModel.SecondLogicViewMoedl  5
   
   -   5        
second��5
   7   .��5      � .+�5   
   �� -   5         ��Name$ firmListBox��5      $
��Left=�6n   $	��100��6�   $��	10,10,0,0q�6�   $	��Top=�6�   $	��372��6�   ��6'   �� *	Filials+ �� SelectedItem 6G   �� *CurrentFilial+��5      �� 5      .R�5      �  � ColumnDefinitions 5      �� 5      62   �� 5      62   �� 5      61   .+�5      �� $��1q�6!   
���   �._�5      �� $	��240��6(    �� Padding$ 10,0,0,0q�64   $��0��6G   ��6X   �� *
FirmName+6t   5      �� 5      $��1��6!   $��1q�61   
���   �._�5      �� $	��240��6(   $ 10,0,0,0q�64   ��6H   �� *
FirmAddres+6f   5      �� 5      $��2��6!   $��1q�61   
���   �._�5      �� $	��235��6(   $ 10,0,0,0q�64   ��6H   �� *	CountSotr+6e   5      5      5       5"      �� 5#   
   -   5        $ sotrudnikListBox1��5#   z    �� SelectionMode$ Multiple=�6<   $
��Left=�6�   $	��100��6�   $��
10,159,0,0q�6�   $	��Top=�6�   $	��372��6�   ��6   �� *CurrentSotrudniki+ 6U   �� *CurrentSotr+��5$      �� 5%       �� 
TargetType" ��6   .�5&      ��  �� Property �@��
IsSelected	 �� Value	 63   �� *
IsSelected+6R   5'      ��5)      �� 5*      .R�5+      �� $��2��6   $��1q�6-   
���   �._�5,      �� $	��235��6$   $ 10,0,0,0q�60   ��6D   �� *Email+6]   5-      5.      50      �� 51   
   -   5        
 ��Name$
 addBtn��51   .   $	��ADD��6>   $
��Left=�6L   $��
10,125,0,0q�6g   $	��Top=�6{   $��55��6�   ��6   �� *
AddEmail+6�   �� 52   
   -   5        $
 removBtn��52   1   $��Remove��6C   $
��Left=�6T   $��
78,125,0,0q�6o   $	��Top=�6�   $��62��6�   ��6   �� *RemoveEmail+6�   �� 53   
   -   5         ��Name$ emailTxt��53   0   $
��Left=�6B   $��23��6]   $��162,126,0,0q�6i    �� TextWrapping$
 Wrap=�6~   $	��Top=�6�   $	��220��6�   ��6   �� *CurrentEmail+6�   55      56      