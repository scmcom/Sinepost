﻿using UnityEngine;
using System;
using System.Collections.Generic;

namespace Sinepost {

	public abstract class Signal : Modulatable, IComparable {

        protected readonly int sampleRate = AudioSettings.outputSampleRate;
		protected readonly double init = AudioSettings.dspTime;
		protected uint check = 0u, channels = 2u;
	    //protected float amplitude, amplitudeModifier = 1f;
		protected float[] panner;
        protected Parameter<Signal> amplitude;

		protected Envelope envelope;
		//Duration parameter;

		//public abstract float Amplitude{ get; set; }
		public abstract float Render{ get; }
		public abstract float Datum{ get; }
		public abstract void Stream(ref float[] data);
		public abstract void Pan(Vector2 position);

        //kill modulation with envelope release.

		public uint SpeakerMode{
			
			get{
				
				switch(AudioSettings.driverCapabilities){
					
				case AudioSpeakerMode.Mono:
					return 1u;
					
				case AudioSpeakerMode.Stereo:
					return 2u;
					
				case AudioSpeakerMode.Prologic:
					return 2u;
					
				case AudioSpeakerMode.Quad:
					return 4u;
					
				case AudioSpeakerMode.Surround:
					return 5u;
					
				case AudioSpeakerMode.Mode5point1:
					return 6u;
					
				case AudioSpeakerMode.Mode7point1:
					return 8u;
					
				default:
					return 2u;
					
				}
				
			}
			
		}
		
		public int CompareTo(object o){

			return 0; //can this be useful?
			
		}

        protected virtual void Setup(float amplitude){

            this.amplitude = new Parameter<Signal>("Amplitude", amplitude);
            parameters.Add(this.amplitude);

        }

        protected virtual void Setup(Instrument context, float amplitude){

            this.amplitude = new Parameter<Signal>(context, "Amplitude", amplitude);
            parameters.Add(this.amplitude);

        }
		
	}

}