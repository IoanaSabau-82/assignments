import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AssignedToPostModule } from './assigned_to_posts/assigned-to-post/assigned-to-post.module';
import { WelcomeComponent } from './home/welcome/welcome.component';
import { PostModule } from './posts/post/post.module';
import { UserListComponent } from './users/user-list/user-list.component';
import { UserModule } from './users/user.module';

@NgModule({
  declarations: [
    AppComponent,
    WelcomeComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    UserModule,
    PostModule,
    AssignedToPostModule
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
