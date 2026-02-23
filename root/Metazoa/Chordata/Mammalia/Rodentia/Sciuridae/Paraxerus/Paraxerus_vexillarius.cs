namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Paraxerus;

/// <summary>
/// Species: Paraxerus vexillarius
/// NCBI TaxId: 234679
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Paraxerus_vexillarius : Paraxerus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Paraxerus vexillarius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Paraxerus_vexillarius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 234679;
}
