namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Cionidae.Ciona;

/// <summary>
/// Species: Ciona cf. intestinalis B AZ-2012
/// NCBI TaxId: 1249493
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ciona_cf_intestinalis_B_AZ_2012 : Ciona
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ciona cf. intestinalis B AZ-2012";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ciona_cf_intestinalis_B_AZ_2012";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1249493;
}
