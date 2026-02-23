namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Callosciurus;

/// <summary>
/// Species: Callosciurus quinquestriatus
/// NCBI TaxId: 2505935
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Callosciurus_quinquestriatus : Callosciurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Callosciurus quinquestriatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Callosciurus_quinquestriatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2505935;
}
