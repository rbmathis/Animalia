namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Psammobates;

/// <summary>
/// Species: Psammobates oculifer
/// NCBI TaxId: 286023
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Psammobates_oculifer : Psammobates
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Psammobates oculifer";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Psammobates_oculifer";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 286023;
}
