namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Lynx;

/// <summary>
/// Species: Lynx canadensis
/// NCBI TaxId: 61383
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lynx_canadensis : Lynx
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lynx canadensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lynx_canadensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 61383;
}
