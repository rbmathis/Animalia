namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Gazella;

/// <summary>
/// Species: Gazella bennettii
/// NCBI TaxId: 69300
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gazella_bennettii : Gazella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gazella bennettii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gazella_bennettii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 69300;
}
