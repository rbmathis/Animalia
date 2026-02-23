namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Synbranchidae.Monopterus;

/// <summary>
/// Species: Monopterus javanensis
/// NCBI TaxId: 1907143
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Monopterus_javanensis : Monopterus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Monopterus javanensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Monopterus_javanensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1907143;
}
