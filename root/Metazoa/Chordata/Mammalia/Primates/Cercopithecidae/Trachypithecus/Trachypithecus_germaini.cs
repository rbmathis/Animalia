namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Trachypithecus;

/// <summary>
/// Species: Trachypithecus germaini
/// NCBI TaxId: 271260
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trachypithecus_germaini : Trachypithecus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trachypithecus germaini";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trachypithecus_germaini";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 271260;
}
