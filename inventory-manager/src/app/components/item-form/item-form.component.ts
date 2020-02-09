import { Component, OnInit } from '@angular/core';

import { FormBuilder, FormGroup, FormArray, Validators } from '@angular/forms';

import axios from 'axios'

import { app } from '../../../config/app'

@Component({
  selector: 'app-item-form',
  templateUrl: './item-form.component.html',
  styleUrls: ['./item-form.component.scss']
})
export class ItemFormComponent implements OnInit {

  itemForm: FormGroup;

  loading = false;
  submitted = false;

  constructor(private fb: FormBuilder) { }

  ngOnInit () {
    this.itemForm = this.fb.group({
      items: this.fb.array([])
    })

    this.itemForm.valueChanges.subscribe(console.log)
  }

  get itemForms () {
    return this.itemForm.get('items') as FormArray
  }

  addItem () {
    const item = this.fb.group({
      itemName: ['', [
        Validators.required
      ]],
      quality: ['', [
        Validators.required,
        Validators.max(50)
      ]],
      sellIn: ['', [
        Validators.required
      ]]
    })

    this.itemForms.push(item);
  }

  get items (): FormArray {
    return this.itemForm.get('items') as FormArray;
  }

  deleteItem (i) {
    this.itemForms.removeAt(i)
  }

  async handleSubmit () {
    this.loading = true

    const values = this.itemForm.value;

    try {
      await axios.post(app.ItemServiceURL`/gettomorrow/values`, values)
    } catch (e) {
      console.error(e)
    }
  }

}