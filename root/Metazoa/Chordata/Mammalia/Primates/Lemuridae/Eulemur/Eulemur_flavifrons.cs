namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae.Eulemur;

/// <summary>
/// Species: Eulemur flavifrons
/// NCBI TaxId: 87288
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eulemur_flavifrons : Eulemur
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eulemur flavifrons";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eulemur_flavifrons";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 87288;
}
