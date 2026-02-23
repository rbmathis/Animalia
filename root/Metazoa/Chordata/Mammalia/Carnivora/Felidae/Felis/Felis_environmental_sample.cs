namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Felis;

/// <summary>
/// Species: Felis environmental sample
/// NCBI TaxId: 2665947
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Felis_environmental_sample : Felis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Felis environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Felis_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2665947;
}
