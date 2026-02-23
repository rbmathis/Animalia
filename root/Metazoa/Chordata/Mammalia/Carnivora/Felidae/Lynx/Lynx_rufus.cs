namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Lynx;

/// <summary>
/// Species: Lynx rufus
/// NCBI TaxId: 61384
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lynx_rufus : Lynx
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lynx rufus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lynx_rufus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 61384;
}
