namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae.Equus;

/// <summary>
/// Species: Equus zebra
/// NCBI TaxId: 9791
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Equus_zebra : Equus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Equus zebra";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Equus_zebra";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9791;
}
