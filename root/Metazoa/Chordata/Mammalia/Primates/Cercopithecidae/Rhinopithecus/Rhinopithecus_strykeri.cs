namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Rhinopithecus;

/// <summary>
/// Species: Rhinopithecus strykeri
/// NCBI TaxId: 1194336
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhinopithecus_strykeri : Rhinopithecus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhinopithecus strykeri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhinopithecus_strykeri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1194336;
}
