namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Colobus;

/// <summary>
/// Species: Colobus angolensis
/// NCBI TaxId: 54131
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Colobus_angolensis : Colobus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Colobus angolensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Colobus_angolensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 54131;
}
