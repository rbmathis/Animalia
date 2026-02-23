namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Triturus;

/// <summary>
/// Species: Triturus karelinii
/// NCBI TaxId: 8325
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Triturus_karelinii : Triturus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Triturus karelinii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Triturus_karelinii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8325;
}
