namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Vanellus;

/// <summary>
/// Species: Vanellus indicus
/// NCBI TaxId: 1003845
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vanellus_indicus : Vanellus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vanellus indicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vanellus_indicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1003845;
}
