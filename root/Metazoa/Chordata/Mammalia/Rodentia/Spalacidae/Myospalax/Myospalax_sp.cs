namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Spalacidae.Myospalax;

/// <summary>
/// Species: Myospalax sp.
/// NCBI TaxId: 106350
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myospalax_sp : Myospalax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myospalax sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myospalax_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 106350;
}
