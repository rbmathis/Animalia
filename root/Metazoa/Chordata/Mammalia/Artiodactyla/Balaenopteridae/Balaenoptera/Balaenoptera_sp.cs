namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Balaenopteridae.Balaenoptera;

/// <summary>
/// Species: Balaenoptera sp.
/// NCBI TaxId: 30557
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Balaenoptera_sp : Balaenoptera
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Balaenoptera sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Balaenoptera_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30557;
}
