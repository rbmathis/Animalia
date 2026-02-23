namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Sousa;

/// <summary>
/// Species: Sousa sahulensis
/// NCBI TaxId: 1921798
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sousa_sahulensis : Sousa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sousa sahulensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sousa_sahulensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1921798;
}
