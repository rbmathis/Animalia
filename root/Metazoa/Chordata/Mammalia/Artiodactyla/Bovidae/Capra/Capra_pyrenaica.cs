namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Capra;

/// <summary>
/// Species: Capra pyrenaica
/// NCBI TaxId: 80419
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Capra_pyrenaica : Capra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Capra pyrenaica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Capra_pyrenaica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 80419;
}
