namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Squalidae.Squalus;

/// <summary>
/// Species: Squalus brevirostris
/// NCBI TaxId: 436290
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squalus_brevirostris : Squalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squalus brevirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squalus_brevirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 436290;
}
