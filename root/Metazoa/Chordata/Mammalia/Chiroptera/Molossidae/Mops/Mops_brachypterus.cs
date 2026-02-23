namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Mops;

/// <summary>
/// Species: Mops brachypterus
/// NCBI TaxId: 3370274
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mops_brachypterus : Mops
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mops brachypterus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mops_brachypterus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3370274;
}
