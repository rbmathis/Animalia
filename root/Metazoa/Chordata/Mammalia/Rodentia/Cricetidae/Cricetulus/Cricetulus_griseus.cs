namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Cricetulus;

/// <summary>
/// Species: Cricetulus griseus
/// NCBI TaxId: 10029
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cricetulus_griseus : Cricetulus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cricetulus griseus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cricetulus_griseus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 10029;
}
