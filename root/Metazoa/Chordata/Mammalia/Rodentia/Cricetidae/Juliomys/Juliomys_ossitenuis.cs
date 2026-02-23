namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Juliomys;

/// <summary>
/// Species: Juliomys ossitenuis
/// NCBI TaxId: 440272
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Juliomys_ossitenuis : Juliomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Juliomys ossitenuis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Juliomys_ossitenuis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 440272;
}
