namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Semnopithecus;

/// <summary>
/// Species: Semnopithecus schistaceus
/// NCBI TaxId: 2804203
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Semnopithecus_schistaceus : Semnopithecus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Semnopithecus schistaceus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Semnopithecus_schistaceus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2804203;
}
