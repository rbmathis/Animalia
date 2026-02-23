namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Echis;

/// <summary>
/// Species: Echis sp.
/// NCBI TaxId: 2109682
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Echis_sp : Echis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Echis sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Echis_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2109682;
}
