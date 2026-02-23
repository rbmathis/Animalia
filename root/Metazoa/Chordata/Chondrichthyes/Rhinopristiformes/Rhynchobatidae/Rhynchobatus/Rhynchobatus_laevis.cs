namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhynchobatidae.Rhynchobatus;

/// <summary>
/// Species: Rhynchobatus laevis
/// NCBI TaxId: 1070983
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhynchobatus_laevis : Rhynchobatus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhynchobatus laevis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhynchobatus_laevis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1070983;
}
