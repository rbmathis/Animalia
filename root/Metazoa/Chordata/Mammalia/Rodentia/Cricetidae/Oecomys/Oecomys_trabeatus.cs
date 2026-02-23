namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oecomys;

/// <summary>
/// Species: Oecomys trabeatus
/// NCBI TaxId: 3424624
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oecomys_trabeatus : Oecomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oecomys trabeatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oecomys_trabeatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3424624;
}
