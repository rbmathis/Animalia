namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Cebus;

/// <summary>
/// Species: Cebus sp.
/// NCBI TaxId: 9517
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cebus_sp : Cebus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cebus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cebus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9517;
}
