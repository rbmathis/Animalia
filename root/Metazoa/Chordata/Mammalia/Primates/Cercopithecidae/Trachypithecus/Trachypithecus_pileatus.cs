namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Trachypithecus;

/// <summary>
/// Species: Trachypithecus pileatus
/// NCBI TaxId: 164651
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trachypithecus_pileatus : Trachypithecus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trachypithecus pileatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trachypithecus_pileatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 164651;
}
