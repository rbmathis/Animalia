namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Suidae.Potamochoerus;

/// <summary>
/// Species: Potamochoerus larvatus
/// NCBI TaxId: 273792
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Potamochoerus_larvatus : Potamochoerus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Potamochoerus larvatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Potamochoerus_larvatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 273792;
}
