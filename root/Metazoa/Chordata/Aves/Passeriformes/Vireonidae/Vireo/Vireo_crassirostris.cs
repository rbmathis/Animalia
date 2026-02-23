namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vireonidae.Vireo;

/// <summary>
/// Species: Vireo crassirostris
/// NCBI TaxId: 768464
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vireo_crassirostris : Vireo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vireo crassirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vireo_crassirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 768464;
}
