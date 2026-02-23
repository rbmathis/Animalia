namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Euneomys;

/// <summary>
/// Species: Euneomys chinchilloides
/// NCBI TaxId: 241144
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Euneomys_chinchilloides : Euneomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Euneomys chinchilloides";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Euneomys_chinchilloides";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 241144;
}
