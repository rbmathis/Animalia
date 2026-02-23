namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae.Ateles;

/// <summary>
/// Species: Ateles paniscus
/// NCBI TaxId: 9510
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ateles_paniscus : Ateles
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ateles paniscus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ateles_paniscus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9510;
}
