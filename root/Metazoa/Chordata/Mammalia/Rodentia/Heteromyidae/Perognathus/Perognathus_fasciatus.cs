namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Heteromyidae.Perognathus;

/// <summary>
/// Species: Perognathus fasciatus
/// NCBI TaxId: 38677
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Perognathus_fasciatus : Perognathus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Perognathus fasciatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Perognathus_fasciatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 38677;
}
