namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cordylidae.Platysaurus;

/// <summary>
/// Species: Platysaurus cf. intermedius
/// NCBI TaxId: 884352
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Platysaurus_cf_intermedius : Platysaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Platysaurus cf. intermedius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Platysaurus_cf_intermedius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 884352;
}
