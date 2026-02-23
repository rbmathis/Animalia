namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Molossus;

/// <summary>
/// Species: Molossus sp. LL-2016
/// NCBI TaxId: 1920528
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Molossus_sp_LL_2016 : Molossus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Molossus sp. LL-2016";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Molossus_sp_LL_2016";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1920528;
}
