namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Phaenomys;

/// <summary>
/// Species: Phaenomys ferrugineus
/// NCBI TaxId: 1560093
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phaenomys_ferrugineus : Phaenomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phaenomys ferrugineus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phaenomys_ferrugineus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1560093;
}
