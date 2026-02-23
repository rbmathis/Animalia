namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Pseudomys;

/// <summary>
/// Species: Pseudomys albocinereus
/// NCBI TaxId: 442603
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pseudomys_albocinereus : Pseudomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pseudomys albocinereus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pseudomys_albocinereus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 442603;
}
