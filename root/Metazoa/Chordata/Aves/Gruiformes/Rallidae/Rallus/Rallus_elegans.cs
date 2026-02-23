namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Rallus;

/// <summary>
/// Species: Rallus elegans
/// NCBI TaxId: 279959
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rallus_elegans : Rallus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rallus elegans";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rallus_elegans";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 279959;
}
