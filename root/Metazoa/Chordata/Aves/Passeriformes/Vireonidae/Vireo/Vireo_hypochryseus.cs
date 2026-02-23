namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vireonidae.Vireo;

/// <summary>
/// Species: Vireo hypochryseus
/// NCBI TaxId: 1162391
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vireo_hypochryseus : Vireo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vireo hypochryseus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vireo_hypochryseus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1162391;
}
