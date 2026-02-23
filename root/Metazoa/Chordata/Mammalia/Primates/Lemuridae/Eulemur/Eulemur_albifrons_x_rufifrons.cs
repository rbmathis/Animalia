namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae.Eulemur;

/// <summary>
/// Species: Eulemur albifrons x rufifrons
/// NCBI TaxId: 1417231
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eulemur_albifrons_x_rufifrons : Eulemur
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eulemur albifrons x rufifrons";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eulemur_albifrons_x_rufifrons";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1417231;
}
