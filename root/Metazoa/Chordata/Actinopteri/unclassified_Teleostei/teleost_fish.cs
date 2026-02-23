namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.unclassified_Teleostei;

/// <summary>
/// Species: teleost fish
/// NCBI TaxId: 70862
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class teleost_fish : unclassified_Teleostei
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "teleost fish";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "teleost_fish";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 70862;
}
