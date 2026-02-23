namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Indriidae.Propithecus;

/// <summary>
/// Species: Propithecus deckenii
/// NCBI TaxId: 475618
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Propithecus_deckenii : Propithecus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Propithecus deckenii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Propithecus_deckenii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 475618;
}
