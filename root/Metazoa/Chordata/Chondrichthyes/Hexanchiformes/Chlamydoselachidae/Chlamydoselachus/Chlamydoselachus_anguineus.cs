namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Hexanchiformes.Chlamydoselachidae.Chlamydoselachus;

/// <summary>
/// Species: Chlamydoselachus anguineus
/// NCBI TaxId: 27585
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chlamydoselachus_anguineus : Chlamydoselachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chlamydoselachus anguineus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chlamydoselachus_anguineus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 27585;
}
