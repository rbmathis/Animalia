namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Rhinopithecus;

/// <summary>
/// Species: Rhinopithecus sp.
/// NCBI TaxId: 1859147
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhinopithecus_sp : Rhinopithecus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhinopithecus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhinopithecus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1859147;
}
