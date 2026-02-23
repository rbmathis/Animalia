namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cheirogaleidae.Microcebus;

/// <summary>
/// Species: Microcebus sp. d'Ambre
/// NCBI TaxId: 1310125
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microcebus_sp_dAmbre : Microcebus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microcebus sp. d'Ambre";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microcebus_sp_dAmbre";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1310125;
}
