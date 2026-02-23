namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oecomys;

/// <summary>
/// Species: Oecomys franciscorum
/// NCBI TaxId: 2135401
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oecomys_franciscorum : Oecomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oecomys franciscorum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oecomys_franciscorum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2135401;
}
