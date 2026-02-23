namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Oreamnos;

/// <summary>
/// Species: Oreamnos americanus
/// NCBI TaxId: 34873
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oreamnos_americanus : Oreamnos
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oreamnos americanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oreamnos_americanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 34873;
}
