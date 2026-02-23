namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Balaenopteridae.Balaenoptera;

/// <summary>
/// Species: Balaenoptera acutorostrata
/// NCBI TaxId: 9767
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Balaenoptera_acutorostrata : Balaenoptera
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Balaenoptera acutorostrata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Balaenoptera_acutorostrata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9767;
}
