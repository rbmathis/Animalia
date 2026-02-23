namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis limifrons
/// NCBI TaxId: 38897
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_limifrons : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis limifrons";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_limifrons";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 38897;
}
