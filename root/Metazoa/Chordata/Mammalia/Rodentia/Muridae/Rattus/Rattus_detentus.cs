namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Rattus;

/// <summary>
/// Species: Rattus detentus
/// NCBI TaxId: 1664380
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rattus_detentus : Rattus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rattus detentus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rattus_detentus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1664380;
}
