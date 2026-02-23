namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Balaenidae.Balaena;

/// <summary>
/// Species: Balaena mysticetus
/// NCBI TaxId: 27602
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Balaena_mysticetus : Balaena
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Balaena mysticetus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Balaena_mysticetus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 27602;
}
