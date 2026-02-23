namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Squalidae.Squalus;

/// <summary>
/// Species: Squalus sp. CBRG-Squa01
/// NCBI TaxId: 2039802
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squalus_sp_CBRG_Squa01 : Squalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squalus sp. CBRG-Squa01";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squalus_sp_CBRG_Squa01";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2039802;
}
