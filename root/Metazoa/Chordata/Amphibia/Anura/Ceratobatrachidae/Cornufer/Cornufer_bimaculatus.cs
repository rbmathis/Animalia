namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratobatrachidae.Cornufer;

/// <summary>
/// Species: Cornufer bimaculatus
/// NCBI TaxId: 3345235
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cornufer_bimaculatus : Cornufer
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cornufer bimaculatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cornufer_bimaculatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3345235;
}
