namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Semnopithecus;

/// <summary>
/// Species: Semnopithecus hector
/// NCBI TaxId: 867382
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Semnopithecus_hector : Semnopithecus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Semnopithecus hector";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Semnopithecus_hector";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 867382;
}
