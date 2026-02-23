namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Crateromys;

/// <summary>
/// Species: Crateromys schadenbergi
/// NCBI TaxId: 2219200
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Crateromys_schadenbergi : Crateromys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Crateromys schadenbergi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Crateromys_schadenbergi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2219200;
}
