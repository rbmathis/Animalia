namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Ziphiidae.Ziphius;

/// <summary>
/// Species: Ziphius cavirostris
/// NCBI TaxId: 9760
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ziphius_cavirostris : Ziphius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ziphius cavirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ziphius_cavirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9760;
}
