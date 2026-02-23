namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Dendropsophus;

/// <summary>
/// Species: Dendropsophus elegans
/// NCBI TaxId: 150706
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dendropsophus_elegans : Dendropsophus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dendropsophus elegans";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dendropsophus_elegans";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 150706;
}
