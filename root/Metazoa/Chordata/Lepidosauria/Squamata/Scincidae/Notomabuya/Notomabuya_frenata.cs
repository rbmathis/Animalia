namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Notomabuya;

/// <summary>
/// Species: Notomabuya frenata
/// NCBI TaxId: 127583
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Notomabuya_frenata : Notomabuya
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Notomabuya frenata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Notomabuya_frenata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 127583;
}
