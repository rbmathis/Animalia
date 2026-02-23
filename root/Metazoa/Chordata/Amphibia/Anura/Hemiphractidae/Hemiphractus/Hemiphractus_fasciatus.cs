namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae.Hemiphractus;

/// <summary>
/// Species: Hemiphractus fasciatus
/// NCBI TaxId: 611320
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hemiphractus_fasciatus : Hemiphractus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hemiphractus fasciatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hemiphractus_fasciatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 611320;
}
