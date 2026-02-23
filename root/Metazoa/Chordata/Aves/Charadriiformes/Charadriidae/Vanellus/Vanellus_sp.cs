namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Vanellus;

/// <summary>
/// Species: Vanellus sp.
/// NCBI TaxId: 2108450
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vanellus_sp : Vanellus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vanellus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vanellus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2108450;
}
