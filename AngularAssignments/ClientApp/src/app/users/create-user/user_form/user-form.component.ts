import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-user-form',
  templateUrl: './user-form.component.html',
  styleUrls: ['./user-form.component.css']
})
export class UserFormComponent implements OnInit {

    userForm = new FormGroup({
        firstName: new FormControl('George'),
        lastName: new FormControl('the1st'),
        email: new FormControl('',[Validators.required]),
        phone: new FormControl({value:'098987', disabled:true})
    });


  constructor() { }

  ngOnInit(): void {
  }

  onSubmit():void {
    console.log(this.userForm);
  }
}
