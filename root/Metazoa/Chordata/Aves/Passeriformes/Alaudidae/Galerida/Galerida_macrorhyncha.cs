namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Galerida;

/// <summary>
/// Species: Galerida macrorhyncha
/// NCBI TaxId: 1365146
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Galerida_macrorhyncha : Galerida
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Galerida macrorhyncha";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Galerida_macrorhyncha";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1365146;
}
