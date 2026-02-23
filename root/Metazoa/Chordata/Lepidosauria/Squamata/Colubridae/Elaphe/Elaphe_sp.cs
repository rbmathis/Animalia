namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Elaphe;

/// <summary>
/// Species: Elaphe sp.
/// NCBI TaxId: 114965
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Elaphe_sp : Elaphe
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Elaphe sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Elaphe_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 114965;
}
