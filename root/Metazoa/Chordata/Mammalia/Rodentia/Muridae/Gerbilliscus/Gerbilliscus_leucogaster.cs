namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Gerbilliscus;

/// <summary>
/// Species: Gerbilliscus leucogaster
/// NCBI TaxId: 410302
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gerbilliscus_leucogaster : Gerbilliscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gerbilliscus leucogaster";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gerbilliscus_leucogaster";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 410302;
}
