# AJ bell technical test, by Liam O'Rourke-Morgan

## Running the App
Prerequisites:
- Docker
- Docker-compose

First time use:
`$ docker-compose up`

Second time use:
`$ docker-compose build`
`$ docker-compose up`

## The Problem
Gilden Rose problem

## Rules:
- All items have a 'SellIn' value which denotes the number of days we have to sell the item.
- All items have a Quality value which denotes how valuable the item is.
- At the end of each day our system lowers bot hvalues for every item.
- Once the sell by date has passed, the quality degrades twice as fast
- The 'Quality' of an item is never negative.
- "Aged Brie" actually increases in Quality the older it gets.
- "Normal Item" decreases in Quality by 1
- The Quality of an Item is never more than 50.
- "Sulfaras" being a legendary item, never has to be sold or decrease in Quality.
- "Backstage Passes" like aged brie, increase in value as its SellIn Value approaches; its quality increases by 2 when there are 10 days or less and by 3 when there are less than 5 days. and then drops to zero
- "Conjured" items degrade in Quality twice as fast as normal items.

## Input:
A list of items in the current inventory. Each line in the input respresents an inventory item with ItemName, its SellIn value and quality. eg `Backstage Passes -1 2`

```json
    {
        ItemName: 'Backstage Passes',
        SellIn: -1,
        Quality: 2
    }
```

## Output
Updated inventory after adjusting the quality and sellin days for each item after a day.

### Test Input
```
Aged Brie 1 1
Backstage passes -1 2
Backstage passes 9 2
Sulfuras 2 2
Normal Item -1 55
Normal Item 2 2
INVALID ITEM 2 2
Conjured 2 2
Conjured -1 5
```

### Expected Output
```
Aged Brie 0 2
Backstage passes -2 0
Backstage passes 8 4
Sulfuras 2 2
Normal Item -2 50
Normal Item 1 1
NO SUCH ITEM
Conjured 1 0
Conjured -2 1
``` 