   M S B A M L   `   `   `  ����J  FFirstMainWindow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:FirstMainWindow.ViewModelFirstMainWindow.ViewModel  5   	        FirstMainWindow.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:FirstMainWindow.ViewModel     5   	     � Title$  
MainWindow��5   	   $	��550��6   $	��925��6)    � DataContext 5	      4   .FirstMainWindow.ViewModel.MainWindowLogicClass  5
   
   -   5        test��5
   5   .��5      � .+�5   
   �� -   5        $��firmNametxtBox��5   -   $
��Left=�6C   $��23��6^   $��	73,10,0,0q�6j    �� TextWrapping$
 Wrap=�6}   $	��Top=�6�   $	��120��6�   ��6   �� *	Firmnames+6�   �� 5   
   -   5        $��addresTxtBox��5   /   $
��Left=�6C   $��23��6^   $��
287,10,0,0q�6j   $
 Wrap=�6~   $	��Top=�6�   $	��120��6�   ��6   �� *FirmAddress+6�   �� 5   
   $��	Firm name��6   $
��Left=�6$   $��10,7,0,0q�6?   $	��Top=�6Q   �� 5   
   $��Firm adress��6   $
��Left=�6&   $��	212,7,0,0q�6A   $	��Top=�6T   �� 5   
   -   5        $��	countSotr��5   .   $
��Left=�6?   $��23��6Z   $��
566,10,0,0q�6f   $
 Wrap=�6z   $	��Top=�6�   $��63��6�   ��6   �� *
CountSotrs+6�   �� 5   
   $��Count sotrudnikov��6   $
��Left=�6,   $��	439,7,0,0q�6G   $	��Top=�6Z   �� 5   
   -   5        $��addFilialBtn��5   D   $��
Add Filial��6/   $
��Left=�6X   $��
702,13,0,0q�6s   $	��Top=�6�   $��76��6�   ��6   �� *	AddFilial+6�   �� 5   
   -   5        $��listBoxWithFilials��5   �   $
��Left=�6�   $	��113��6�   $��	38,69,0,0q�6�   $	��Top=�6�   $	��740��6�    �� SelectedItem 6   �� *CurrentFilial+ �� SelectedIndex 69   �� *SelectionChange+��6c   �� *	Filials+��5      �� 5      .R�5      �  � ColumnDefinitions 5      �� 5      62   �� 5      62   �� 5      61   .+�5      �� $��1q�6!   
���   �._�5      �� $	��240��6(    �� Padding$ 10,0,0,0q�64   $��0��6G   ��6X   �� *
FirmName+6t   5       �� 5!      $��1��6!   $��1q�61   
���   �._�5"      �� $	��240��6(   $ 10,0,0,0q�64   ��6H   �� *
FirmAddres+6f   5#      �� 5$      $��2��6!   $��1q�61   
���   �._�5%      �� $	��235��6(   $ 10,0,0,0q�64   ��6H   �� *	CountSotr+6e   5&      5'      5(      5*      �� 5+   
   -   5         ��Name$ addEmailBtn��5+   A   $��	Add Email��6-   $
��Left=�6V   $��
798,69,0,0q�6q   $	��Top=�6�   $��76��6�   $	��113��6�   ��6   �� *	AddSotr+6�   �� 5,   
   -   5        $��listBoxWithSotrEmails��5,   �    �� SelectionMode$ Multiple=�6   $
��Left=�6�   $	��112��6�   $��
38,230,0,0q�6�   $	��Top=�6�   $	��750��6�    6,   �� *CurrentSotrudnic+��6V   �� *CurrentSotrudniki+��5-      �� 5.      	 �� 
TargetType"	 ��6   .�5/      �� 
 �� Property
 �@��
IsSelected �� Value 63   �� *
IsSelected+6R   50      ��52      �� 53      .R�54      �� $��2��6   $��1q�6-   
���   �._�55      �� $	��700��6$   $ 10,0,0,0q�60   ��6D   �� *Email+6]   56      57      59      �� 5:   
   -	   5        $ startSendingBtn��5:   I   $��Start Sending��61   $
��Left=�6b   $��798,230,0,0q�6}   $	��Top=�6�   $��76��6�   $	��113��6�   ��6   �� *SendMessage+6�   �� 5;   
   -
   5         ��Name$ subjecttxtBox��5;   +   $
��Left=�6B   $��86��6]   $��110,406,0,0q�6i   $
 Wrap=�6~   $	��Top=�6�   $	��125��6�   ��6   �� *	Subject+6�   �� 5<   
   -   5        $ 
bodyTxtBox��5<   (   $
��Left=�6<   $��86��6W   $��332,406,0,0q�6c   $
 Wrap=�6x   $	��Top=�6�   $	��542��6�   ��6   �� *Body+6�   �� 5=   
   $��Subject��6   $
��Left=�6"   $��
44,403,0,0q�6=   $	��Top=�6Q   $��68��6i   �� 5>   
   $
��Body��6   $
��Left=�6   $��254,403,0,0q�6:   $	��Top=�6O   $��72��6g   5@      5A      