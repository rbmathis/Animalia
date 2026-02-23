namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Ichthyosaura;

/// <summary>
/// Species: Ichthyosaura alpestris
/// NCBI TaxId: 54263
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ichthyosaura_alpestris : Ichthyosaura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ichthyosaura alpestris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ichthyosaura_alpestris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 54263;
}
