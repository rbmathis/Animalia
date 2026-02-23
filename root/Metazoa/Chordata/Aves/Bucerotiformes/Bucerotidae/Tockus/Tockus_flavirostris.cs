namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae.Tockus;

/// <summary>
/// Species: Tockus flavirostris
/// NCBI TaxId: 302528
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tockus_flavirostris : Tockus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tockus flavirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tockus_flavirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 302528;
}
