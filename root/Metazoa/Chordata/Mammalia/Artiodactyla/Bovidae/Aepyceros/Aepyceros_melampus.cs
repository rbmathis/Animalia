namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Aepyceros;

/// <summary>
/// Species: Aepyceros melampus
/// NCBI TaxId: 9897
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aepyceros_melampus : Aepyceros
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aepyceros melampus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aepyceros_melampus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9897;
}
