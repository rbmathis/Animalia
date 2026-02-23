namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Geochelone;

/// <summary>
/// Species: Geochelone elegans
/// NCBI TaxId: 180179
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Geochelone_elegans : Geochelone
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Geochelone elegans";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Geochelone_elegans";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 180179;
}
