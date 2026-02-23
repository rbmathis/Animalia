namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Caviidae.Galea;

/// <summary>
/// Species: Galea sp. CH-2002
/// NCBI TaxId: 270236
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Galea_sp_CH_2002 : Galea
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Galea sp. CH-2002";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Galea_sp_CH_2002";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 270236;
}
