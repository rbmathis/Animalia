namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Microauris;

/// <summary>
/// Species: Microauris aurantolabium
/// NCBI TaxId: 2307264
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microauris_aurantolabium : Microauris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microauris aurantolabium";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microauris_aurantolabium";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2307264;
}
