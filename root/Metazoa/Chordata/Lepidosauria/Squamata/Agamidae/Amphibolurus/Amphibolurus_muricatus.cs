namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Amphibolurus;

/// <summary>
/// Species: Amphibolurus muricatus
/// NCBI TaxId: 116113
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amphibolurus_muricatus : Amphibolurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amphibolurus muricatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amphibolurus_muricatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 116113;
}
