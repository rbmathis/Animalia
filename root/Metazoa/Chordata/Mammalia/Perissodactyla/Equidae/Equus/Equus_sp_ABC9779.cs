namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae.Equus;

/// <summary>
/// Species: Equus sp. ABC9779
/// NCBI TaxId: 2835450
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Equus_sp_ABC9779 : Equus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Equus sp. ABC9779";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Equus_sp_ABC9779";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2835450;
}
