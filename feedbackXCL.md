## Feedback

### 10.9

- Livraison du 5.9:
  - Release: OK, sauf qu'il manque les pdf, qui doivent etre joints à la release
  - Nommage des commits: A améliorer
  - Rapport:
    - Mettez la version Word dans votre repo. C'est ce fichier qu'il est important de mettre sous controle de version car c'est sur lui que vous travaillez
    - Vous n'avez pas bien compris (ou au moins décrit) ce que sont les objectifs pédagogiques. Il s'agit de savoir programmer en OO, pas de faire un jeu
  - User stories: Bien ! Conseil: ajoutez la maquette directement dans les issues concernées, après les tests d'acceptance. Vous pourrez ensuite bénéficier pleinement de [GitStories](https://github.com/ETML-INF/GitStories)
  - Journal: devrait etre en pdf, attaché à la release, mais il est OK
  - Grille d'évaluation: OK

### 8.10

- Nommage des commits OK
- Le rapport est encore très vide
- J'ai regardé un peu plus la question de la rotation du bitmap, mais ce n'est vraiment pas simple et ça risque d'être coûteux en performance. Je vous suggère une approche plus directe: créez 5 bitmaps de taille égale avec les blocs déjà tournés dedans. Dans le modèle, ajoutez un attribut "rotation" et utilisez-le dans la vue pour choisir quel image afficher.

## 80%

Les valeurs possibles du résultat sont: LA (Largement Acquis), A (Acquis), I (Insuffisant), NA (non acquis)

| Critère                    | Résultat | Commentaire                                                                                                                                                                                                                                                                        |
| -------------------------- | -------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Avancement Obstacles       | I        | il manque les hitbox                                                                                                                                                                                                                                                               |
| Avancement Joueur          | A        |                                                                                                                                                                                                                                                                                    |
| Avancement Tirs            | I        | je peux voir que le travail est en cours                                                                                                                                                                                                                                           |
| Avancement ennemis         | NA       | la classe mob est vide                                                                                                                                                                                                                                                             |
| Avancement score           | NA       |                                                                                                                                                                                                                                                                                    |
| Qualité Présentation       | A        |                                                                                                                                                                                                                                                                                    |
| Qualité Commentaires       | A        |                                                                                                                                                                                                                                                                                    |
| Qualité Conventions        | I        | les méthodes doivent suivre la convention UpperCamelCase. Pareil pour les noms de classe                                                                                                                                                                                           |
| POO                        | I        | améliorez la modélisation : lorsque l'on frappe une touche, ce n'est pas la PlayZone qui doit modifier la position du joueur : elle doit simplement lui dire de bouger dans une certaine direction et c'est dans la classe Player que l'on va changer effectivement la position.   |
| Processus Journal          | I        | la version PDF du journal est illisible. À part ça : OK                                                                                                                                                                                                                            |
| Processus Git              | A        |                                                                                                                                                                                                                                                                                    |
| Processus Livraison        | LA       |                                                                                                                                                                                                                                                                                    |
| Expression User Stories    | I        | telle qu'elle est formulée, la US "le joueur peut tirer" ne me permet pas vraiment de comprendre comment le joueur s'y prend pour tirer <br>N'hésitez pas à mettre plusieurs fois la même maquette pour différentes US. Typiquement en ce qui concerne les blocs autour du joueur. |
| Expression Rapport Forme   | I        | modifier l'image de la page de garde                                                                                                                                                                                                                                               |
| Expression Rapport Contenu | I        | le rapport est très très vide.                                                                                                                                                                                                                                                     |
| Ecologie (gitignore)       | A        |                                                                                                                                                                                                                                                                                    |
| Comportement collectif     | A        |                                                                                                                                                                                                                                                                                    |
| Comportement individuel    | A        |                                                                                                                                                                                                                                                                                    |
## Final

livraison, impeccable

journal de (Travail) : à l'avenir, vérifiez ce que vous livrez avant de le faire. Votre journal fait 11 pages, il n'y a que la première qui contient des informations.

le jeu n'est pas complètement fonctionnel, mais il comportait des difficultés particulières qui font que je considère l'état du code comme satisfaisant

je l'ai dit et répété : il ne suffit pas de copier coller un diagramme dans une section du rapport pour que le travail soit terminé. Le diagramme doit être commenté dans la section.

L'analyse fonctionnelle n'est pas correcte. Ce que vous avez mis dans votre rapport n'est pas une analyse fonctionnelle. Relisez le project handbook: l'analyse fonctionnelle doit être présentée sous forme de User Story

le rapport ne contient pas la section expliquant le recours que vous avez fait à l'IA

Points à remédier d'ici au 8 novembre (refaire une livraison):
  - commenter le diagramme de classe dans le rapport
  -  inclure vos user Stories dans le rapport OU  y mettre  des liens sur les issues sur Github
  -   ajouter la section d'explications IA

## Remédiation

Attention : vous avez bien ajouté les références à vos US, mais les liens ne fonctionnent pas.  
J'avais demandé un minimum de 250 mots pour la section IA. On est vraiment très loin du compte.

Malgré cela, je valide votre projet.
