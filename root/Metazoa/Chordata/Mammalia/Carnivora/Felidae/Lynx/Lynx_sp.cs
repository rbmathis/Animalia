namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Lynx;

/// <summary>
/// Species: Lynx sp.
/// NCBI TaxId: 3435967
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lynx_sp : Lynx
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lynx sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lynx_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3435967;
}
