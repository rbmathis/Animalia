namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Pelobatrachus;

/// <summary>
/// Species: Pelobatrachus baluensis
/// NCBI TaxId: 389874
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelobatrachus_baluensis : Pelobatrachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelobatrachus baluensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelobatrachus_baluensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 389874;
}
