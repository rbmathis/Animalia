namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Rhinopithecus;

/// <summary>
/// Species: Rhinopithecus bieti
/// NCBI TaxId: 61621
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhinopithecus_bieti : Rhinopithecus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhinopithecus bieti";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhinopithecus_bieti";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 61621;
}
