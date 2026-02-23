namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae.Ursus;

/// <summary>
/// Species: Ursus rossicus
/// NCBI TaxId: 1530197
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ursus_rossicus : Ursus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ursus rossicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ursus_rossicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1530197;
}
