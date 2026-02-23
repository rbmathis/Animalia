namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Bison;

/// <summary>
/// Species: Bison antiquus
/// NCBI TaxId: 304335
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bison_antiquus : Bison
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bison antiquus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bison_antiquus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 304335;
}
