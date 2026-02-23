namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Calidris;

/// <summary>
/// Species: Calidris tenuirostris
/// NCBI TaxId: 171266
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Calidris_tenuirostris : Calidris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Calidris tenuirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Calidris_tenuirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 171266;
}
