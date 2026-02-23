namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Semnopithecus;

/// <summary>
/// Species: Semnopithecus sp.
/// NCBI TaxId: 1778600
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Semnopithecus_sp : Semnopithecus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Semnopithecus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Semnopithecus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1778600;
}
