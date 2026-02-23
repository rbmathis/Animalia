namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Sphenisciformes.Spheniscidae.Spheniscus;

/// <summary>
/// Species: Spheniscus humboldti
/// NCBI TaxId: 9240
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Spheniscus_humboldti : Spheniscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Spheniscus humboldti";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Spheniscus_humboldti";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9240;
}
