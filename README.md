# FindNoLANServerFixer

Wenn ihr mal wieder den GameServer auf einer LAN nicht finden könnt, liegt das vermutlich nicht nur an eurer Firewall.
Es kann sein, dass eure Routing-Tabellen nicht richtig eingerichtet sind und die Broadcasts in das falsche Netz wandern.

In frühreren Windows Versionen reichte es noch die Priorität eurer Netzwerkadapter zu ändern. Viele von euch kennen dieses Trick sicher noch.
Doch dies hat in modernen Windows Versionen nicht mehr den nötigen Effekt, dass die zugehörige Broadcast Adressen anders priorisiert werden.

Um es euch leichter zu machen, habe ich dieses Tool geschrieben.

Wählt dort einfach euren Ethernet/WLAN Adapter aus über den ihr mit dem Server / den anderen Spielern komunizieren möchtet.
Den Rest mach mein Tool für euch.

Und keine Sorge.
Die Änderungen in den Routing Tabellen sind nicht persistent.
Sprich nach einem Windows Neustart ist alles wieder wie vorher.

Viel Spaß :)
Ich hoffe eure Suche hat hier ein Ende und das zocken kann endlich anfangen.
Niemand will wieder dieser Eine sein, welcher nicht auf den Server kommt und alles aufhällt. ;)

Direkter Download:
https://github.com/mengelskirchen/FindNoLANServerFixer/blob/master/FindNoLANServerFixer/bin/Debug/FindNoLANServerFixer.exe
