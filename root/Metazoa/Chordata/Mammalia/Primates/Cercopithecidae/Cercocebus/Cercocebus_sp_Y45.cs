namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Cercocebus;

/// <summary>
/// Species: Cercocebus sp. Y45
/// NCBI TaxId: 2959324
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cercocebus_sp_Y45 : Cercocebus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cercocebus sp. Y45";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cercocebus_sp_Y45";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2959324;
}
