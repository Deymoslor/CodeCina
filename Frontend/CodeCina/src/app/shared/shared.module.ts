import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NabvarComponent } from './components/nabvar/nabvar.component';
import { FooterComponent } from './components/footer/footer.component';



@NgModule({
  declarations: [
    NabvarComponent,
    FooterComponent
  ],
  imports: [
    CommonModule
  ]
})
export class SharedModule { }
