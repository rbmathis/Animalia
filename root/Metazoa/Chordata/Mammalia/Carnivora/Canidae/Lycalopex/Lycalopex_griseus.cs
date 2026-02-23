namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Lycalopex;

/// <summary>
/// Species: Lycalopex griseus
/// NCBI TaxId: 68737
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lycalopex_griseus : Lycalopex
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lycalopex griseus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lycalopex_griseus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 68737;
}
