namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae.Eulemur;

/// <summary>
/// Species: Eulemur rufifrons
/// NCBI TaxId: 859984
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eulemur_rufifrons : Eulemur
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eulemur rufifrons";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eulemur_rufifrons";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 859984;
}
