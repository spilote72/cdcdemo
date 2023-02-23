# POC - Utilisation d'un hash (SHA-256) pour faciliter la détection de changements

## Hypothèses généraux

- Le mécanisme utilise seulement les champs qui doivent être validé (pas de champs techniques ou métadonnées)
- Le mécanisme est simple et standardisé (réplicabilité)
- Avec des paramètres semblable, le mécanisme donne le même résultat à chaque fois
- Le mécanisme n'est pas propre à une plateforme ni une architecture de processeur distinct (portabilité)

## Cas d'utilisation 1: Sérialisation d'un objet en json

### Hypothèeses:

- Seul les champs qui doivent être validé sont sérialisés
- Avec des paramètres semblable, la sérialisation donne le même résultat à chaque fois

### Résultats

Le principe fonctionne comme prévu. En appliquant l'attribut *JsonIgnore" sur les champs techniques, nous atteignons l'objectif.

**Avantages de la solution:**

- Simple à mettre en oeuvre
- Requiert peu de code

**Désavantages**

- Gestion et maintenance des entités avec les attributs
- Test d'ordre de la sérialisation des propriétés n'a pas été fait, pourrait produire des valeurs différentes
- Controle sur l'ordre de sérialisation pas clair
- Si on a un changement de nom de colonne, toutes les valeurs passées seront invalidés vu que le nom des champs sont inclus dans le hash

Conclusion: **NE PAS UTILISÉ**

