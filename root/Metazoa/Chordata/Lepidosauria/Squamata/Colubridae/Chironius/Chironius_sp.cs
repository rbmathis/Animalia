namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Chironius;

/// <summary>
/// Species: Chironius sp.
/// NCBI TaxId: 2029152
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chironius_sp : Chironius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chironius sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chironius_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2029152;
}
