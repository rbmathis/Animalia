namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Suidae.Potamochoerus;

/// <summary>
/// Species: Potamochoerus porcus
/// NCBI TaxId: 273791
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Potamochoerus_porcus : Potamochoerus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Potamochoerus porcus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Potamochoerus_porcus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 273791;
}
