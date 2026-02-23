namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Saiga;

/// <summary>
/// Species: Saiga tatarica
/// NCBI TaxId: 34875
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Saiga_tatarica : Saiga
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Saiga tatarica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Saiga_tatarica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 34875;
}
