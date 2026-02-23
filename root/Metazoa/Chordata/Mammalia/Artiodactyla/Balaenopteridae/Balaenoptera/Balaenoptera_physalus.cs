namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Balaenopteridae.Balaenoptera;

/// <summary>
/// Species: Balaenoptera physalus
/// NCBI TaxId: 9770
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Balaenoptera_physalus : Balaenoptera
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Balaenoptera physalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Balaenoptera_physalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9770;
}
