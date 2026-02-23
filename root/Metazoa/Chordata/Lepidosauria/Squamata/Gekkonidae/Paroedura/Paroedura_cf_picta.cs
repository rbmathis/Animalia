namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Paroedura;

/// <summary>
/// Species: Paroedura cf. picta
/// NCBI TaxId: 3156060
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Paroedura_cf_picta : Paroedura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Paroedura cf. picta";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Paroedura_cf_picta";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3156060;
}
