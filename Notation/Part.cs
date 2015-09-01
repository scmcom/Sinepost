﻿#region License
//
// Sinepost
// Copyright (c) 2015 Jonathan A. Califa
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

namespace Sinepost.Notation {

	public class Part : Notated {
		
		rhythmic beat;
		cyclic note;
		public int index;
		
		public Part(rhythmic beat, cyclic note){
			
			this.temperament = EqualTemperament(12u, 440f);
			
		}
		
		public Part(rhythmic beat, cyclic note, Tuning temperament){
			
			this.temperament = temperament;
			
		}
		
		public static Part operator + (Part input1, Part input2){
			
			Part output = input1;
			
			return output;
			
		}
		
	}

}
