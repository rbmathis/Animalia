namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Thinornis;

/// <summary>
/// Species: Thinornis rubricollis
/// NCBI TaxId: 50410
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thinornis_rubricollis : Thinornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thinornis rubricollis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thinornis_rubricollis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 50410;
}
