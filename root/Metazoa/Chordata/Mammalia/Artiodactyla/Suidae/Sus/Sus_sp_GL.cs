namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Suidae.Sus;

/// <summary>
/// Species: Sus sp. GL
/// NCBI TaxId: 432589
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sus_sp_GL : Sus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sus sp. GL";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sus_sp_GL";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 432589;
}
