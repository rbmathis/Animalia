namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Rattus;

/// <summary>
/// Species: Rattus mordax
/// NCBI TaxId: 472761
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rattus_mordax : Rattus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rattus mordax";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rattus_mordax";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 472761;
}
