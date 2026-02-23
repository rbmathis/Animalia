namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Tonatia;

/// <summary>
/// Species: Tonatia sp. ECT-2005
/// NCBI TaxId: 318598
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tonatia_sp_ECT_2005 : Tonatia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tonatia sp. ECT-2005";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tonatia_sp_ECT_2005";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 318598;
}
