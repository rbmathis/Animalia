namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Neacomys;

/// <summary>
/// Species: Neacomys cf. amoenus 'Northern Peru'
/// NCBI TaxId: 1962399
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Neacomys_cf_amoenus_Northern_Peru : Neacomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Neacomys cf. amoenus 'Northern Peru'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Neacomys_cf_amoenus_Northern_Peru";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1962399;
}
