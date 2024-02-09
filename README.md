# Unity-AI-prototype

Prototype d'idée d'AI sur Unity. 

# Fonctionnement 

Graph de décision où les noeuds sont des états auxquels sont liées des comportements. Afin de choisir le prochaine état, on se base sur l'état précédant. 
Ainsi, l'AI prend des décisions en fonctions des états (décisions) précédante. 

# Utilisation 

WASD permet de bouger le "Joueur" (le cercle) alors que l'"AI" est le carré. Au début, l'"AI" est endormie, puis se réveille et est "happy" si le joueur est proche
"angry" si il est loin. Après quelques secondes l'"AI" s'endort puis le cycle recommence !

# UML des classes 

![UML-des-classes](https://github.com/nBeeckmans/unity-ai-prototype/blob/master/UML-AI.svg)

# Schémas des décisions 

![Schémas des décisions](https://github.com/nBeeckmans/unity-ai-prototype/blob/master/graphviz.svg)
