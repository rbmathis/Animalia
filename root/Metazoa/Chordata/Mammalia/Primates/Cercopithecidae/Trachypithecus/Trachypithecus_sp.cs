namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Trachypithecus;

/// <summary>
/// Species: Trachypithecus sp.
/// NCBI TaxId: 580599
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trachypithecus_sp : Trachypithecus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trachypithecus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trachypithecus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 580599;
}
