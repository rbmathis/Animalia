namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oecomys;

/// <summary>
/// Species: Oecomys matogrossensis
/// NCBI TaxId: 2829237
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oecomys_matogrossensis : Oecomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oecomys matogrossensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oecomys_matogrossensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2829237;
}
