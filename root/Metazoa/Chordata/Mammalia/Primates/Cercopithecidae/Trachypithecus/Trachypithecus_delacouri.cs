namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Trachypithecus;

/// <summary>
/// Species: Trachypithecus delacouri
/// NCBI TaxId: 465717
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trachypithecus_delacouri : Trachypithecus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trachypithecus delacouri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trachypithecus_delacouri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 465717;
}
