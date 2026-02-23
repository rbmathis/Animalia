namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Sousa;

/// <summary>
/// Species: Sousa chinensis
/// NCBI TaxId: 103600
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sousa_chinensis : Sousa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sousa chinensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sousa_chinensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 103600;
}
