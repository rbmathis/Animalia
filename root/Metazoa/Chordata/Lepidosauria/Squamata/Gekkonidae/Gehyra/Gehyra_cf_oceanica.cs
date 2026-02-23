namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Gehyra;

/// <summary>
/// Species: Gehyra cf. oceanica
/// NCBI TaxId: 1208032
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gehyra_cf_oceanica : Gehyra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gehyra cf. oceanica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gehyra_cf_oceanica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1208032;
}
