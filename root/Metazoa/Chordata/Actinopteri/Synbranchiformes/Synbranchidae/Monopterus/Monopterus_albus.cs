namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Synbranchidae.Monopterus;

/// <summary>
/// Species: Monopterus albus
/// NCBI TaxId: 43700
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Monopterus_albus : Monopterus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Monopterus albus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Monopterus_albus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 43700;
}
