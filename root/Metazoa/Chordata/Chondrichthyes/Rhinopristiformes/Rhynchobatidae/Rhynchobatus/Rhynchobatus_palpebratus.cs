namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhynchobatidae.Rhynchobatus;

/// <summary>
/// Species: Rhynchobatus palpebratus
/// NCBI TaxId: 1213713
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhynchobatus_palpebratus : Rhynchobatus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhynchobatus palpebratus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhynchobatus_palpebratus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1213713;
}
