namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Dasypodidae.Dasypus;

/// <summary>
/// Species: Dasypus pilosus
/// NCBI TaxId: 1756219
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dasypus_pilosus : Dasypus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dasypus pilosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dasypus_pilosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1756219;
}
