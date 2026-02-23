namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae.Hemiphractus;

/// <summary>
/// Species: Hemiphractus proboscideus
/// NCBI TaxId: 317322
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hemiphractus_proboscideus : Hemiphractus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hemiphractus proboscideus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hemiphractus_proboscideus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 317322;
}
