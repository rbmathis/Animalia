namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Cercocebus;

/// <summary>
/// Species: Cercocebus sp.
/// NCBI TaxId: 3413534
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cercocebus_sp : Cercocebus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cercocebus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cercocebus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3413534;
}
