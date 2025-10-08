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
