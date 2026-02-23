namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Incilius;

/// <summary>
/// Species: Incilius marmoreus
/// NCBI TaxId: 302544
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Incilius_marmoreus : Incilius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Incilius marmoreus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Incilius_marmoreus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 302544;
}
