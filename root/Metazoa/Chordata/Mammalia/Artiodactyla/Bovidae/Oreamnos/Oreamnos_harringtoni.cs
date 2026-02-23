namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Oreamnos;

/// <summary>
/// Species: Oreamnos harringtoni
/// NCBI TaxId: 665113
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oreamnos_harringtoni : Oreamnos
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oreamnos harringtoni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oreamnos_harringtoni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 665113;
}
