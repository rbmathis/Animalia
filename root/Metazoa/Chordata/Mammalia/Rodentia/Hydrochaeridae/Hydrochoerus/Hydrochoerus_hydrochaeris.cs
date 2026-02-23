namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Hydrochaeridae.Hydrochoerus;

/// <summary>
/// Species: Hydrochoerus hydrochaeris
/// NCBI TaxId: 10149
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hydrochoerus_hydrochaeris : Hydrochoerus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hydrochoerus hydrochaeris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hydrochoerus_hydrochaeris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 10149;
}
