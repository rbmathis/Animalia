namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae.Eulemur;

/// <summary>
/// Species: Eulemur fulvus
/// NCBI TaxId: 13515
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eulemur_fulvus : Eulemur
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eulemur fulvus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eulemur_fulvus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 13515;
}
