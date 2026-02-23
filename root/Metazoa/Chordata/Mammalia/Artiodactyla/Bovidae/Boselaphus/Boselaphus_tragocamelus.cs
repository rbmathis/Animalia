namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Boselaphus;

/// <summary>
/// Species: Boselaphus tragocamelus
/// NCBI TaxId: 9917
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Boselaphus_tragocamelus : Boselaphus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Boselaphus tragocamelus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Boselaphus_tragocamelus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9917;
}
