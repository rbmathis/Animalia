namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Tragelaphus;

/// <summary>
/// Species: Tragelaphus imberbis
/// NCBI TaxId: 9947
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tragelaphus_imberbis : Tragelaphus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tragelaphus imberbis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tragelaphus_imberbis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9947;
}
