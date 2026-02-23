namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Colobus;

/// <summary>
/// Species: Colobus sp.
/// NCBI TaxId: 34824
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Colobus_sp : Colobus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Colobus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Colobus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 34824;
}
