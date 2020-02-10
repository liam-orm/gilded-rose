import { Component, OnInit } from '@angular/core';

import { FormBuilder, FormGroup, FormArray, Validators } from '@angular/forms';

import axios from 'axios'

import { app } from '../../../config/app'
import { Item } from 'src/app/models/Item';
import { TimeoutError } from 'rxjs';

@Component({
  selector: 'app-item-form',
  templateUrl: './item-form.component.html',
  styleUrls: ['./item-form.component.scss']
})
export class ItemFormComponent implements OnInit {

  itemForm: FormGroup;

  processedItems: Item[] = [];

  constructor(private fb: FormBuilder) { }

  ngOnInit () {
    this.itemForm = this.fb.group({
      ItemName: ['', [
        Validators.required
      ]],
      Quality: ['', [
        Validators.required
      ]],
      SellIn: ['', [
        Validators.required
      ]]
    })
  }

  get itemForms () {
    return this.itemForm.get('items') as FormArray
  }

  get ItemName () {
    return this.itemForm.get('ItemName')
  }

  get Quality () {
    return this.itemForm.get('Quality')
  }

  get SellIn () {
    return this.itemForm.get('SellIn')
  }

  async handleSubmit () {
    const data = this.itemForm.value

    try {
      axios({
        method: 'post',
        url: `${app.ItemServiceURL}/inventory`,
        data: data
      }).then(result => {
        this.processedItems.push(result.data)
      });
    } catch (e) {
      console.error(e)
    }
  }

}
