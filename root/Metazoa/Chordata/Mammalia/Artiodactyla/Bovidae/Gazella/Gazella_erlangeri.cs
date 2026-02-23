namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Gazella;

/// <summary>
/// Species: Gazella erlangeri
/// NCBI TaxId: 1088686
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gazella_erlangeri : Gazella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gazella erlangeri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gazella_erlangeri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1088686;
}
