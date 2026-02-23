namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Turdus;

/// <summary>
/// Species: Turdus sp.
/// NCBI TaxId: 2805848
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Turdus_sp : Turdus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Turdus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Turdus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2805848;
}
