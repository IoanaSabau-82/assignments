import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { NgForm} from '@angular/forms';
import { UserModel } from '../models/user_class';
import { UserFormComponent } from './user_form/user-form.component';



@Component({
  selector: 'app-create-user',
  templateUrl: './create-user.component.html',
  styleUrls: ['./create-user.component.css']
})
export class CreateUserComponent implements OnInit {
  //receive data from parent
  //receive data from parent
  @Input()
  receiveStringFromParent!: string;
  @Input()
  receiveObjectFromParent!: object;
  @Input()
  receiveFirst!: string;

  //send data to parent
  @Output()
  messageEvent = new EventEmitter<string>();
  message: string = "Hello parent! i i send you data this many times:";
  counter: number = 1;


  //forms
  user = new UserModel();

  userReactive = new UserFormComponent();

  onSubmit(form: NgForm) {
    console.log(form)
  }

  onTouch(x:any){
    console.log(x);
  }

  onButtonClick(){
    this.messageEvent.emit(this.message + this.counter++);
  }

  constructor() { }

  ngOnInit(): void {
  }

}
