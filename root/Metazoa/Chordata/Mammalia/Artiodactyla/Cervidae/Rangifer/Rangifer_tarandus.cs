namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Rangifer;

/// <summary>
/// Species: Rangifer tarandus
/// NCBI TaxId: 9870
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rangifer_tarandus : Rangifer
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rangifer tarandus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rangifer_tarandus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9870;
}
