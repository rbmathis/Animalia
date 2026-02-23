namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Indriidae.Propithecus;

/// <summary>
/// Species: Propithecus tattersalli
/// NCBI TaxId: 30601
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Propithecus_tattersalli : Propithecus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Propithecus tattersalli";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Propithecus_tattersalli";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30601;
}
