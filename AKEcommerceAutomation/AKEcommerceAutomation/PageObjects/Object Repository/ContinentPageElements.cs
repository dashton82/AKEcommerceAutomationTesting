﻿//-----------------------------------------------------------------------
// <copyright company="Abercombie&kent">
//     Copyright (c) Abercombie&Kent. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace AKEcommerceAutomation.PageObjects.Object_Repository
{
    using OpenQA.Selenium;

    public class ContinentPageElements
    {
        /// <summary>
        /// Africa continennt navigation link
        /// </summary>
        public static By Navigation = By.CssSelector("[class='page-nav'] li a");
            
        /// <summary>
        /// Africa continennt Vector map
        /// </summary>
        public static By Africacontinentmap = By.Id("Content_T7A9807F6015_Col00");

        /// <summary>
        /// CSS Selector of SouthAfrica
        /// </summary>
        public static By southAfrica = By.CssSelector("area[alt='South Africa']");

        /// <summary>
        /// ID of the Carousel Image
        /// </summary>
        public static By CarouselImage = By.Id("Content_T7A9807F6017_Col00");

        /// <summary>
        /// css selector of country elements
        /// </summary>
        public static By countries = By.CssSelector("[class='header-2 sf_2cols-show']");

        /// <summary>
        /// css selector of country Images 
        /// </summary>
        public static By CountryImages = By.XPath("//*[@id='infiniteScrollItem']/div[1]/div[1]/div/section/article/a/div");

    }
}
