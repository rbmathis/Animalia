namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Psammobates;

/// <summary>
/// Species: Psammobates geometricus
/// NCBI TaxId: 286013
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Psammobates_geometricus : Psammobates
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Psammobates geometricus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Psammobates_geometricus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 286013;
}
