Simulator for radio-controlled cars

OBS! Simulatorn funkar inte, läs nedan.

Hade problem när det kom till att få trucken att styra, kände att 
den lösning jag hade kommit fram till i slutändan troligtvis hade varit onödig mycket kod med nästlade if och for-satser.

Tänkte låta en variabel avgöra vilken riktning trucken åkte, och att den tredje inputen från användaren skulle påverka variabeln.
R -> +1, L -> -1 (max 4, vilket jag tänkte lösa m.h.a. remainder/rest-operators). 1 = north, 2 = east, 3 = south, 4 = south.
Sen att F och B mest gör antingen t.ex. posX +/- 1.

Sen har jag ingen i princip ingen error-handling ännu, tänkte att det skulle lösas på slutet.
Säkert en massa andra fel ni kan se, och finns givetvis smartare sätt att lösa uppgiften kan jag tro.

Har en mindre "programmerings-kurs" på gymnasiet där vi gick igenom grunderna i C#, annars har jag ingen tyngre erfarenhet av
C#, förutom likheterna av andra kodspråk.

Det jag kodade tog cirka 6 timmar, uppdelat på två pass.
