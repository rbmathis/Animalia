namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae.Pan;

/// <summary>
/// Species: Pan paniscus
/// NCBI TaxId: 9597
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pan_paniscus : Pan
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pan paniscus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pan_paniscus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9597;
}
