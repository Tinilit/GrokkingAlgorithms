import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LayoutComponent } from './shared/layout/layout.component';
import { AlgorithmsResultsComponent} from './components/algorithms-results/algorithms-results.component';


const routes: Routes = [
  {
    path:'', component:LayoutComponent,
    children:[
      {
        path:'', component: AlgorithmsResultsComponent
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
