namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oecomys;

/// <summary>
/// Species: Oecomys flavicans
/// NCBI TaxId: 3370443
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oecomys_flavicans : Oecomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oecomys flavicans";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oecomys_flavicans";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3370443;
}
