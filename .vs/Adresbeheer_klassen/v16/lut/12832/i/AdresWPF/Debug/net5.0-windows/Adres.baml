   M S B A M L   `   `   `  ����C  ?AdresWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:AdresWPFAdresWPF  5   	       AdresWPF.Adres   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:AdresWPF     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5   	   $��Regular"�5	   	   $��13(�5
   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ Adres��5   	   $	��450��6   $	��800��6$   .��5      � 
����ح�.+�5   
   �� .+�5      #  MaterialDesignThemes.Wpf.Card  $��32q�6"   $��16q�6/   $��66��6;    J� RenderTransformOrigin$ 0.501,0.736&�6G   .��5      ��  $  MaterialDesignHeadline6TextBlock#���  6   Adresbeheer6d   5      5      �� 5   
   $��Adres��6   $��Verdana)�6    $��40(�65   $
��Left=�6C   $��	20,20,0,0q�6^   $	��Top=�6q   $��55��6�   $	��302��6�   �� 5   
   -   5         ��Name$ AdressenSelecteren��5      $��Selecteer adres��6-   $
��Left=�6G   $��606,283,0,0q�6b   $	��Top=�6w   $��52��6�   $	��167��6�   $ 0.359,0.562&�6�   6�   �� 5   
   -   5        $ AdressenBestaan��5      $��Bestaat adres?��6*   $
��Left=�6C   $��606,220,0,0q�6^   $	��Top=�6s   $��45��6�   $	��167��6�   6�   �� 5   
   -   5        $ Adressenverwijderen��5      $��Verwijder adres��6.   $
��Left=�6H   $��606,155,0,0q�6c   $	��Top=�6x   $��50��6�   $	��167��6�   6�   �� 5   
   -   5        $ AdressenToevoegen��5      $��Voeg adres toe��6,   $
��Left=�6E   $��
606,97,0,0q�6`   $	��Top=�6t   $��40��6�   $	��167��6�   6�   �� 5   
   -   5        $ 
GaNaarHome��5      $��Keer terug naar main��6%   $
��Left=�6D   $��
608,13,0,0q�6_   $	��Top=�6s   $��69��6�   $	��182��6�   6�   �� 5   
   -   5        $ AdressenUpdaten��5      $��Udate adres��6*   $
��Left=�6@   $��606,357,0,0q�6[   $	��Top=�6p   $��58��6�   $	��165��6�   6�   �� 5   
   -   5         ��Name$ labelID��5      $��ID��6!   $��20,102,696,297q�6.   �� 5   
   -   5        $ labelStraatID��5      $��Straatid��6'   $��20,137,696,262q�6:   �� 5    
   -	   5        $ labelHuisnummer��5       $��
Huisnummer��6)   $��20,172,696,227q�6>   �� 5!   
   -
   5        $ labelBusnummer��5!      $��	Busnummer��6(   $��20,212,696,187q�6<   �� 5"   
   -   5        $ labelAppnummer��5"      $��	Appnummer��6(   $��20,254,696,145q�6<   �� 5#   
   -   5        $ labelHuisnummerlabel��5#      $��Huisnummerlabel��6.   $��20,294,673,104q�6H   �� 5$   
   -   5        $ labelPostcode��5$      $��Postcode��6'   $��20,339,696,60q�6:   �� 5%   
   -   5        $ labelAdresLocatieID��5%      $��	LocatieID��6-   $��20,389,696,10q�6A   �� 5&   
   -   5         ��Name$ 	textBoxID��5&      $��ID��6%    �� TextWrapping$
 Wrap=�6/   $	��120��6C   $��351,90,329,314q�6O   �� 5'   
   -   5        $ textBoxStraatID��5'      $��	StraatiId��6+   $
 Wrap=�6<   $	��120��6P   $��351,122,329,282q�6\   �� 5(   
   -   5        $ textBoxLocatieHuisnummer��5(      $��
Huisnummer��64   $
 Wrap=�6F   $	��120��6Z   $��351,160,329,244q�6f   �� 5)   
   -   5        $ textBoxBusnummer��5)      $��	Busnummer��6,   $
 Wrap=�6=   $	��120��6Q   $��351,200,329,204q�6]   �� 5*   
   -   5        $ textBoxAppnummer��5*      $��	Appnummer��6,   $
 Wrap=�6=   $	��120��6Q   $��351,242,329,162q�6]   �� 5+   
   -   5        $# textBoxLocatieHuisnummerlabel��5+      $��Huisnummerlabel��69   $
 Wrap=�6P   $	��120��6d   $��351,283,329,122q�6p   �� 5,   
   -   5        $ textBoxPostcode��5,      $��Postcode��6+   $
 Wrap=�6;   $	��120��6O   $��351,327,329,77q�6[   �� 5-   
   -   5        $ textBoxLocatieID��5-      $��	LocatieID��6,   $
 Wrap=�6=   $	��120��6Q   $��351,375,329,27q�6]   5.      5/      