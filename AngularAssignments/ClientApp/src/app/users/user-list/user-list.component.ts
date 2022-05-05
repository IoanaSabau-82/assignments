import { AfterViewInit, Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { CreateUserComponent } from '../create-user/create-user.component';
import { IUserModel } from '../models/user_interface';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.css']
})
export class UserListComponent implements OnInit, AfterViewInit {

  pageTitle = "user list";
  showImage = true;
  imageUrl = "assets/images/pexels-pixabay-104827.jpg";
  imageWidth=100;
  inputMargin=10;
  aLink = "https://angular.io/start"
  switchTrial = '30';

  someText = "to be dispayed inner html";

  twoWayBind = "initial value";

  users: IUserModel[] = [
    {
      firstName :"Anca",
      lastName : "Popa",
      email: "",
      phone: "",

    },
    {
      firstName :"Dan",
      lastName : "Bartos",
      email: "",
      phone: "",
    },
    {
      firstName :"Dan",
      lastName : "Amariei",
      email: "",
      phone: "",
    },
  ]
  
  sendStringToChild = "some data";
  sendObjectToChild = {
    firstName : "date",
    lastName : "de test"
  };

  receiveHelloMessage!: string;

  @ViewChild(CreateUserComponent)
  createUser: any;
  
  @ViewChild('title')
  title!: ElementRef;

  now:Date = new Date();
  displayText = "this is just some random text";

  constructor() { }

  toggleImage():void{
    this.showImage = !this.showImage;
  }

  ngOnInit(): void {
  }

  displayMessage(msg:string){
    this.receiveHelloMessage = msg;
  }


  ngAfterViewInit() {
   console.log("message from child", this.createUser.message)
    console.log(this.title.nativeElement());

  }

  getDataFromCreateUser()
  {
    this.createUser.onButtonClick();
  }
}
