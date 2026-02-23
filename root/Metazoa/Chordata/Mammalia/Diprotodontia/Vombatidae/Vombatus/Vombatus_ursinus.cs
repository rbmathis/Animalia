namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Vombatidae.Vombatus;

/// <summary>
/// Species: Vombatus ursinus
/// NCBI TaxId: 29139
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vombatus_ursinus : Vombatus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vombatus ursinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vombatus_ursinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 29139;
}
