namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Sorex;

/// <summary>
/// Species: Sorex sp.
/// NCBI TaxId: 3237282
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sorex_sp : Sorex
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sorex sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sorex_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3237282;
}
