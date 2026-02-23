namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Procapra;

/// <summary>
/// Species: Procapra przewalskii
/// NCBI TaxId: 157668
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Procapra_przewalskii : Procapra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Procapra przewalskii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Procapra_przewalskii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 157668;
}
