namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Calidris;

/// <summary>
/// Species: Calidris alpina
/// NCBI TaxId: 8919
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Calidris_alpina : Calidris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Calidris alpina";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Calidris_alpina";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8919;
}
