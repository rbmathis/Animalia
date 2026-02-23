namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhynchobatidae.Rhynchobatus;

/// <summary>
/// Species: Rhynchobatus sp. 'Red Sea/Mozambique'
/// NCBI TaxId: 1735963
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhynchobatus_sp_Red_SeaMozambique : Rhynchobatus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhynchobatus sp. 'Red Sea/Mozambique'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhynchobatus_sp_Red_SeaMozambique";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1735963;
}
