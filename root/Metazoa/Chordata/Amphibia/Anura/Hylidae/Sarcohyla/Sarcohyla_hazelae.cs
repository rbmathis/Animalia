namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Sarcohyla;

/// <summary>
/// Species: Sarcohyla hazelae
/// NCBI TaxId: 2018390
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sarcohyla_hazelae : Sarcohyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sarcohyla hazelae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sarcohyla_hazelae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2018390;
}
