namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Indriidae.Propithecus;

/// <summary>
/// Species: Propithecus sp.
/// NCBI TaxId: 39582
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Propithecus_sp : Propithecus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Propithecus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Propithecus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 39582;
}
