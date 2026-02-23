namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Suidae.Potamochoerus;

/// <summary>
/// Species: Potamochoerus sp. BXL005
/// NCBI TaxId: 2706468
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Potamochoerus_sp_BXL005 : Potamochoerus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Potamochoerus sp. BXL005";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Potamochoerus_sp_BXL005";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2706468;
}
