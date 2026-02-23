namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae.Ailuropoda;

/// <summary>
/// Species: Ailuropoda melanoleuca
/// NCBI TaxId: 9646
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ailuropoda_melanoleuca : Ailuropoda
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ailuropoda melanoleuca";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ailuropoda_melanoleuca";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9646;
}
