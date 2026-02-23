namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Thryonomyidae.Thryonomys;

/// <summary>
/// Species: Thryonomys sp.
/// NCBI TaxId: 1695229
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thryonomys_sp : Thryonomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thryonomys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thryonomys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1695229;
}
