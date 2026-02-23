namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhynchobatidae.Rhynchobatus;

/// <summary>
/// Species: Rhynchobatus sp. 'Arabian Gulf'
/// NCBI TaxId: 1735962
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhynchobatus_sp_Arabian_Gulf : Rhynchobatus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhynchobatus sp. 'Arabian Gulf'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhynchobatus_sp_Arabian_Gulf";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1735962;
}
