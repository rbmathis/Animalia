namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae.Macropus;

/// <summary>
/// Species: Macropus giganteus
/// NCBI TaxId: 9317
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Macropus_giganteus : Macropus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Macropus giganteus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Macropus_giganteus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9317;
}
