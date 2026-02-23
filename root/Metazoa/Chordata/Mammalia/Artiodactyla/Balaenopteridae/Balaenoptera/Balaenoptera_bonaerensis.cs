namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Balaenopteridae.Balaenoptera;

/// <summary>
/// Species: Balaenoptera bonaerensis
/// NCBI TaxId: 33556
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Balaenoptera_bonaerensis : Balaenoptera
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Balaenoptera bonaerensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Balaenoptera_bonaerensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 33556;
}
