namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Rhinopithecus;

/// <summary>
/// Species: Rhinopithecus avunculus
/// NCBI TaxId: 66062
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhinopithecus_avunculus : Rhinopithecus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhinopithecus avunculus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhinopithecus_avunculus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 66062;
}
