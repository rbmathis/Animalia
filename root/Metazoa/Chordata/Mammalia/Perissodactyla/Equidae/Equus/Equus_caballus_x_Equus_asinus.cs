namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae.Equus;

/// <summary>
/// Species: Equus caballus x Equus asinus
/// NCBI TaxId: 1050200
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Equus_caballus_x_Equus_asinus : Equus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Equus caballus x Equus asinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Equus_caballus_x_Equus_asinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1050200;
}
