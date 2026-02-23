namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Oreotragus;

/// <summary>
/// Species: Oreotragus oreotragus
/// NCBI TaxId: 66444
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oreotragus_oreotragus : Oreotragus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oreotragus oreotragus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oreotragus_oreotragus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 66444;
}
