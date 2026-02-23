namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Proteidae.Necturus;

/// <summary>
/// Species: Necturus lewisi
/// NCBI TaxId: 43528
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Necturus_lewisi : Necturus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Necturus lewisi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Necturus_lewisi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 43528;
}
