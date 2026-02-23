namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Monotremata.Tachyglossidae.Tachyglossus;

/// <summary>
/// Species: Tachyglossus aculeatus
/// NCBI TaxId: 9261
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tachyglossus_aculeatus : Tachyglossus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tachyglossus aculeatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tachyglossus_aculeatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9261;
}
