namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Kinosternidae.Staurotypus;

/// <summary>
/// Species: Staurotypus triporcatus
/// NCBI TaxId: 55537
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Staurotypus_triporcatus : Staurotypus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Staurotypus triporcatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Staurotypus_triporcatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 55537;
}
