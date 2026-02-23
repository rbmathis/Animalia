namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Calidris;

/// <summary>
/// Species: Calidris temminckii
/// NCBI TaxId: 328946
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Calidris_temminckii : Calidris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Calidris temminckii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Calidris_temminckii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 328946;
}
