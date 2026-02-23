namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae.Equus;

/// <summary>
/// Species: Equus sp. AV191
/// NCBI TaxId: 2835492
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Equus_sp_AV191 : Equus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Equus sp. AV191";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Equus_sp_AV191";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2835492;
}
