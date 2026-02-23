namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Sphenisciformes.Spheniscidae.Spheniscus;

/// <summary>
/// Species: Spheniscus magellanicus
/// NCBI TaxId: 37081
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Spheniscus_magellanicus : Spheniscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Spheniscus magellanicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Spheniscus_magellanicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 37081;
}
