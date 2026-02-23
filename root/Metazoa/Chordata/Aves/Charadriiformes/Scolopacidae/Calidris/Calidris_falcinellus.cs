namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Calidris;

/// <summary>
/// Species: Calidris falcinellus
/// NCBI TaxId: 3149495
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Calidris_falcinellus : Calidris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Calidris falcinellus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Calidris_falcinellus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3149495;
}
