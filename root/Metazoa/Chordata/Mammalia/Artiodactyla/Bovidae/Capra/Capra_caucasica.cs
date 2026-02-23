namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Capra;

/// <summary>
/// Species: Capra caucasica
/// NCBI TaxId: 72540
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Capra_caucasica : Capra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Capra caucasica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Capra_caucasica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 72540;
}
