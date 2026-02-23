namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Megapodiidae.Megapodius;

/// <summary>
/// Species: Megapodius cumingii
/// NCBI TaxId: 177165
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Megapodius_cumingii : Megapodius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Megapodius cumingii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Megapodius_cumingii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 177165;
}
