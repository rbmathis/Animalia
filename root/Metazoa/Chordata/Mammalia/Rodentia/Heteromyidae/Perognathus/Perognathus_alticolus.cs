namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Heteromyidae.Perognathus;

/// <summary>
/// Species: Perognathus alticolus
/// NCBI TaxId: 323380
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Perognathus_alticolus : Perognathus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Perognathus alticolus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Perognathus_alticolus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 323380;
}
