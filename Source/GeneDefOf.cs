﻿using RimWorld;
using Verse;
using Verse.AI;
namespace RJW_Genes
{
	[DefOf]
	public static class GeneDefOf
	{
		public static readonly GeneCategoryDef rjw_genes_genitalia_type;
		public static readonly GeneCategoryDef rjw_genes_genitalia_size;
		public static readonly GeneCategoryDef rjw_genes_gender;
		public static readonly GeneCategoryDef rjw_genes_breeding;
		public static readonly GeneCategoryDef rjw_genes_damage;
		public static readonly GeneCategoryDef rjw_genes_special;

		// Base Genitalia Types
		public static readonly GeneDef rjw_genes_equine_genitalia;
		public static readonly GeneDef rjw_genes_demonic_genitalia;
		public static readonly GeneDef rjw_genes_dragon_genitalia;
		public static readonly GeneDef rjw_genes_slime_genitalia;
		public static readonly GeneDef rjw_genes_ovipositor_genitalia;
		public static readonly GeneDef rjw_genes_feline_genitalia;
		public static readonly GeneDef rjw_genes_canine_genitalia;
        public static readonly GeneDef rjw_genes_demonicT_genitalia;
        public static readonly GeneDef rjw_genes_crocodilian_genitalia;
        public static readonly GeneDef rjw_genes_racoon_genitalia;
        public static readonly GeneDef rjw_genes_reptilian_genitalia;
        public static readonly GeneDef rjw_genes_Ghost_genitalia;
        public static readonly GeneDef rjw_genes_Golem_genitalia;
        public static readonly GeneDef rjw_genes_Marine_genitalia;
        public static readonly GeneDef rjw_genes_Necro_genitalia;
        public static readonly GeneDef rjw_genes_Needle_genitalia;
        public static readonly GeneDef rjw_genes_Orc_genitalia;
        public static readonly GeneDef rjw_genes_Pig_genitalia;
        public static readonly GeneDef rjw_genes_Tentacle_genitalia;

        // Extra Genitalia 
        public static readonly GeneDef rjw_genes_extra_penis;
		public static readonly GeneDef rjw_genes_no_penis;
		public static readonly GeneDef rjw_genes_extra_vagina;
		public static readonly GeneDef rjw_genes_no_vagina;
		public static readonly GeneDef rjw_genes_extra_breasts;
		public static readonly GeneDef rjw_genes_no_breasts;
		public static readonly GeneDef rjw_genes_extra_anus;
		public static readonly GeneDef rjw_genes_no_anus;
		public static readonly GeneDef rjw_genes_futa;
        public static readonly GeneDef rjw_genes_femboy;
        public static readonly GeneDef rjw_genes_featureless_chest; 
		public static readonly GeneDef rjw_genes_udder;

        // Genitalia Sizes
        public static readonly GeneDef rjw_genes_big_male_genitalia;
		public static readonly GeneDef rjw_genes_small_male_genitalia;
		public static readonly GeneDef rjw_genes_loose_female_genitalia;
		public static readonly GeneDef rjw_genes_tight_female_genitalia;
		public static readonly GeneDef rjw_genes_big_breasts;
		public static readonly GeneDef rjw_genes_small_breasts;
		public static readonly GeneDef rjw_genes_loose_anus;
		public static readonly GeneDef rjw_genes_tight_anus;
		public static readonly GeneDef rjw_genes_evergrowth;

		// Gender 
		public static readonly GeneDef rjw_genes_female_only;
		public static readonly GeneDef rjw_genes_male_only;
		public static readonly GeneDef rjw_genes_gender_fluid;

		// Breeding
		public static readonly GeneDef rjw_genes_mechbreeder;
		public static readonly GeneDef rjw_genes_zoophile;
        public static readonly GeneDef rjw_genes_fertile_anus;
        // Cum 
        public static readonly GeneDef rjw_genes_no_cum;
		public static readonly GeneDef rjw_genes_much_cum;
		public static readonly GeneDef rjw_genes_very_much_cum;
		[MayRequire("LustLicentia.RJWLabs")] public static readonly GeneDef rjw_genes_likes_cumflation;
		[MayRequire("LustLicentia.RJWLabs")] public static readonly GeneDef rjw_genes_cumflation_immunity;
		[MayRequire("LustLicentia.RJWLabs")] public static readonly GeneDef rjw_genes_generous_donor; 
		
		// Reproduction 
		public static readonly GeneDef rjw_genes_hypersexual;
		public static readonly GeneDef rjw_genes_rapist;
		public static readonly GeneDef rjw_genes_homosexual;
		public static readonly GeneDef rjw_genes_bisexual;
		public static readonly GeneDef rjw_genes_no_sex_need;

		// Damage & Side Effects 
		[MayRequire("LustLicentia.RJWLabs")] public static readonly GeneDef rjw_genes_elasticity;
		public static readonly GeneDef rjw_genes_unbreakable;

		// Special
		public static readonly GeneDef rjw_genes_orgasm_rush;
		public static readonly GeneDef rjw_genes_youth_fountain;
		public static readonly GeneDef rjw_genes_sex_age_drain;
		public static readonly GeneDef rjw_genes_aphrodisiac_pheromones;
		public static readonly GeneDef rjw_genes_sexual_mytosis;
		public static readonly GeneDef rjw_genes_hormonal_saliva;

       

	}

}
