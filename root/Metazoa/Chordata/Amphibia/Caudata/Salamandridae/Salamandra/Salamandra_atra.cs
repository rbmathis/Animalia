namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Salamandra;

/// <summary>
/// Species: Salamandra atra
/// NCBI TaxId: 57570
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Salamandra_atra : Salamandra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Salamandra atra";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Salamandra_atra";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 57570;
}
