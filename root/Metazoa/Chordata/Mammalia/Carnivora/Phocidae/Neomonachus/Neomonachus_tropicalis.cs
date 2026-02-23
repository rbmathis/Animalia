namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae.Neomonachus;

/// <summary>
/// Species: Neomonachus tropicalis
/// NCBI TaxId: 1295174
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Neomonachus_tropicalis : Neomonachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Neomonachus tropicalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Neomonachus_tropicalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1295174;
}
