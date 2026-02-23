namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Feylinia;

/// <summary>
/// Species: Feylinia cf. polylepis
/// NCBI TaxId: 293411
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Feylinia_cf_polylepis : Feylinia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Feylinia cf. polylepis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Feylinia_cf_polylepis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 293411;
}
