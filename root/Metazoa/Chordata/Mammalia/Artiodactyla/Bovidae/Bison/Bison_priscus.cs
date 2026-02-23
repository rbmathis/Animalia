namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Bison;

/// <summary>
/// Species: Bison priscus
/// NCBI TaxId: 268291
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bison_priscus : Bison
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bison priscus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bison_priscus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 268291;
}
