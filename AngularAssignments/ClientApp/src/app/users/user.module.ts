import { NgModule, Pipe } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UserListComponent } from './user-list/user-list.component';
import { CreateUserComponent } from './create-user/create-user.component';
import { UpdateUserComponent } from './update-user/update-user.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { UserFormComponent } from './create-user/user_form/user-form.component';
import { AddValuePipe } from '../pipes/add-value.pipe';
import { RemoveLetterEPipe } from '../pipes/remove-letter-e.pipe';


@NgModule({
  declarations: [
    UserListComponent,
    CreateUserComponent,
    UpdateUserComponent,
    UserFormComponent,
    AddValuePipe,
    RemoveLetterEPipe,
  ],
  
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,

  ]
})
export class UserModule { }
