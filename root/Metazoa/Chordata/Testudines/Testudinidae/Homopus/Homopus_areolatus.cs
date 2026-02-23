namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Homopus;

/// <summary>
/// Species: Homopus areolatus
/// NCBI TaxId: 285996
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Homopus_areolatus : Homopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Homopus areolatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Homopus_areolatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 285996;
}
