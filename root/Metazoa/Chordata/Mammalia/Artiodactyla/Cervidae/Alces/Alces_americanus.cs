namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Alces;

/// <summary>
/// Species: Alces americanus
/// NCBI TaxId: 999462
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Alces_americanus : Alces
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Alces americanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Alces_americanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 999462;
}
