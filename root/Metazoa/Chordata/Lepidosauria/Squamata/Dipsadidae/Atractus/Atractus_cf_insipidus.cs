namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Atractus;

/// <summary>
/// Species: Atractus cf. insipidus
/// NCBI TaxId: 3402016
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Atractus_cf_insipidus : Atractus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Atractus cf. insipidus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Atractus_cf_insipidus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3402016;
}
