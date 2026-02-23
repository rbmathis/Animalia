namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Prionailurus;

/// <summary>
/// Species: Prionailurus bengalensis
/// NCBI TaxId: 37029
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Prionailurus_bengalensis : Prionailurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Prionailurus bengalensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Prionailurus_bengalensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 37029;
}
