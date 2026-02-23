namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Proteidae.Necturus;

/// <summary>
/// Species: Necturus maculosus
/// NCBI TaxId: 42757
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Necturus_maculosus : Necturus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Necturus maculosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Necturus_maculosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 42757;
}
