namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Trachypithecus;

/// <summary>
/// Species: Trachypithecus shortridgei
/// NCBI TaxId: 1042121
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trachypithecus_shortridgei : Trachypithecus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trachypithecus shortridgei";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trachypithecus_shortridgei";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1042121;
}
