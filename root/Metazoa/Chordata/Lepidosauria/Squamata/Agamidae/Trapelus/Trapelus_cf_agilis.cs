namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Trapelus;

/// <summary>
/// Species: Trapelus cf. agilis
/// NCBI TaxId: 1001383
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trapelus_cf_agilis : Trapelus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trapelus cf. agilis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trapelus_cf_agilis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1001383;
}
