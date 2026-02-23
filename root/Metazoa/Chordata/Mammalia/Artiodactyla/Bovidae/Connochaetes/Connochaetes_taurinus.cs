namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Connochaetes;

/// <summary>
/// Species: Connochaetes taurinus
/// NCBI TaxId: 9927
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Connochaetes_taurinus : Connochaetes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Connochaetes taurinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Connochaetes_taurinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9927;
}
