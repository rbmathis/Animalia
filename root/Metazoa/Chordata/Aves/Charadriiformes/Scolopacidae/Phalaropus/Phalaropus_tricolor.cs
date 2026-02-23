namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Phalaropus;

/// <summary>
/// Species: Phalaropus tricolor
/// NCBI TaxId: 227175
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phalaropus_tricolor : Phalaropus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phalaropus tricolor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phalaropus_tricolor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 227175;
}
