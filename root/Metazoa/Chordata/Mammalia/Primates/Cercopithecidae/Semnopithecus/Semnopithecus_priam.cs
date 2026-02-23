namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Semnopithecus;

/// <summary>
/// Species: Semnopithecus priam
/// NCBI TaxId: 1208733
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Semnopithecus_priam : Semnopithecus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Semnopithecus priam";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Semnopithecus_priam";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1208733;
}
