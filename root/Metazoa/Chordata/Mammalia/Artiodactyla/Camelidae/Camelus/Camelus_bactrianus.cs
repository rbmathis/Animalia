namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Camelidae.Camelus;

/// <summary>
/// Species: Camelus bactrianus
/// NCBI TaxId: 9837
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Camelus_bactrianus : Camelus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Camelus bactrianus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Camelus_bactrianus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9837;
}
