namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Cercocebus;

/// <summary>
/// Species: Cercocebus torquatus
/// NCBI TaxId: 9530
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cercocebus_torquatus : Cercocebus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cercocebus torquatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cercocebus_torquatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9530;
}
