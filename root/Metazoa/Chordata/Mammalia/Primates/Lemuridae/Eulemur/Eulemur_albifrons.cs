namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae.Eulemur;

/// <summary>
/// Species: Eulemur albifrons
/// NCBI TaxId: 1215604
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eulemur_albifrons : Eulemur
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eulemur albifrons";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eulemur_albifrons";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1215604;
}
