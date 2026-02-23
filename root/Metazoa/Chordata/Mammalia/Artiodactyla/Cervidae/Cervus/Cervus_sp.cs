namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Cervus;

/// <summary>
/// Species: Cervus sp.
/// NCBI TaxId: 27598
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cervus_sp : Cervus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cervus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cervus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 27598;
}
