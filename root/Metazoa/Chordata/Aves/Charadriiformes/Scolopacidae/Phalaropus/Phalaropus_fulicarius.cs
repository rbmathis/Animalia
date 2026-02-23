namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Phalaropus;

/// <summary>
/// Species: Phalaropus fulicarius
/// NCBI TaxId: 279952
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phalaropus_fulicarius : Phalaropus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phalaropus fulicarius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phalaropus_fulicarius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 279952;
}
