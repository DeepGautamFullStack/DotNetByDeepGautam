import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ConsumeRestAPIService } from './service/consume-rest-api.service'

import { AppComponent } from './app.component';
import { AppCrudOperationComponent } from './Components/app.crudoperation.component';

@NgModule({
    imports: [BrowserModule, HttpModule, ReactiveFormsModule ],
  declarations: [AppComponent, AppCrudOperationComponent],
  providers: [ConsumeRestAPIService],
  bootstrap: [AppComponent ]
})
export class AppModule { }
