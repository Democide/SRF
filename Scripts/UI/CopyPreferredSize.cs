﻿#if ENABLE_4_6_FEATURES

using SRF.Internal;
using UnityEngine;
using UnityEngine.UI;

namespace SRF.UI
{

	/// <summary>
	/// Copies the preferred size of another layout element (useful for a parent object basing its sizing from a child element).
	/// This does have very quirky behaviour, though.
	/// </summary>
	[RequireComponent(typeof(RectTransform))]
	[ExecuteInEditMode]
	[AddComponentMenu(ComponentMenuPaths.CopyPreferredSize)]
	public class CopyPreferredSize : LayoutElement
	{

		public RectTransform CopySource;

		public float PaddingWidth;
		public float PaddingHeight;

	
		public override float preferredWidth
		{
			get
			{
				if (CopySource == null || !IsActive())
					return -1f;
				return LayoutUtility.GetPreferredWidth(CopySource) + PaddingWidth;
			}
		}

		public override float preferredHeight
		{
			get
			{
				if (CopySource == null || !IsActive())
					return -1f;
				return LayoutUtility.GetPreferredHeight(CopySource) + PaddingHeight;
			}
		}

		public override int layoutPriority
		{
			get { return 2; }
		}

		/*public void CalculateLayoutInputHorizontal()
		{
			foreach (var component in CopySource.GetComponents(typeof (ILayoutElement))) {
				(component as ILayoutElement).CalculateLayoutInputHorizontal();
			}
		}

		public void CalculateLayoutInputVertical()
		{
			foreach (var component in CopySource.GetComponents(typeof(ILayoutElement))) {
				(component as ILayoutElement).CalculateLayoutInputVertical();
			}
		}*/

	}
}

#endif