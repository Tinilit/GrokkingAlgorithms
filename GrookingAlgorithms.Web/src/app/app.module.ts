import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LayoutComponent } from './shared/layout/layout.component';
import {MatTableModule} from '@angular/material'
import { AlgorithmsResultsComponent } from './components/algorithms-results/algorithms-results.component';
import { HttpClientModule }from '@angular/common/http';
import { AlgorithmResultsService } from './services/algorithm-results/algorithm-results.service';

@NgModule({
  declarations: [
    AppComponent,
    LayoutComponent,
    AlgorithmsResultsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatTableModule,
    HttpClientModule
  ],
  providers: [AlgorithmResultsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
