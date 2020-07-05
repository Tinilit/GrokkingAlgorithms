import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LayoutComponent } from './shared/layout/layout.component';
import { AlgorithmsResultsComponent } from './components/algorithms-results/algorithms-results.component';

@NgModule({
  declarations: [
    AppComponent,
    LayoutComponent,
    AlgorithmsResultsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
