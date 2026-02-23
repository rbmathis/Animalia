namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Tiliqua;

/// <summary>
/// Species: Tiliqua multifasciata
/// NCBI TaxId: 1843165
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tiliqua_multifasciata : Tiliqua
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tiliqua multifasciata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tiliqua_multifasciata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1843165;
}
