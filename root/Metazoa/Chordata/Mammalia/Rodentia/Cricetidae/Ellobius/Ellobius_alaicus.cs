namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Ellobius;

/// <summary>
/// Species: Ellobius alaicus
/// NCBI TaxId: 2052900
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ellobius_alaicus : Ellobius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ellobius alaicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ellobius_alaicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2052900;
}
