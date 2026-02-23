namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae.Equus;

/// <summary>
/// Species: Equus przewalskii x Equus caballus
/// NCBI TaxId: 1263311
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Equus_przewalskii_x_Equus_caballus : Equus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Equus przewalskii x Equus caballus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Equus_przewalskii_x_Equus_caballus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1263311;
}
