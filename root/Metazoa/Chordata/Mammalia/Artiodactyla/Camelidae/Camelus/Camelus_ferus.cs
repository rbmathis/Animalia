namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Camelidae.Camelus;

/// <summary>
/// Species: Camelus ferus
/// NCBI TaxId: 419612
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Camelus_ferus : Camelus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Camelus ferus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Camelus_ferus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 419612;
}
