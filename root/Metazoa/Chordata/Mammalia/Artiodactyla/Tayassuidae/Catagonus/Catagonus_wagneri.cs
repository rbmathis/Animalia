namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Tayassuidae.Catagonus;

/// <summary>
/// Species: Catagonus wagneri
/// NCBI TaxId: 51154
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Catagonus_wagneri : Catagonus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Catagonus wagneri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Catagonus_wagneri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 51154;
}
