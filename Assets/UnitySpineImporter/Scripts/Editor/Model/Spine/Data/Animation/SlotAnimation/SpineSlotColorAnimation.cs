﻿using LitJson;

namespace UnitySpineImporter{
	public class SpineSlotColorAnimation {
		public double           time;
		public string           color; // FFFFFFFF hex
		public JsonData curve; /*
									The interpolation to use between this and the next keyframe. One of: linear, stepped, or an array defining a Bézier curve. Assume “linear” if omitted.
									The Bézier curve array has 4 elements which define the control points: cx1, cy1, cx2, cy2. The X axis is from 0 to 1 and represents the percent of time between the two keyframes. The Y axis is from 0 to 1 and represents the percent of the difference between the keyframe’s values.
									*/
	}
}
