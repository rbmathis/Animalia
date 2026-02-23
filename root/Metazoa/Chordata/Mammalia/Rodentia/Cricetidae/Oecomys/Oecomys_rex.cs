namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oecomys;

/// <summary>
/// Species: Oecomys rex
/// NCBI TaxId: 202792
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oecomys_rex : Oecomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oecomys rex";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oecomys_rex";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 202792;
}
