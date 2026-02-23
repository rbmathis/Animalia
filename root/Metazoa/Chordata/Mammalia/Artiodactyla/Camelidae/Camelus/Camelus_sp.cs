namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Camelidae.Camelus;

/// <summary>
/// Species: Camelus sp.
/// NCBI TaxId: 30536
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Camelus_sp : Camelus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Camelus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Camelus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30536;
}
