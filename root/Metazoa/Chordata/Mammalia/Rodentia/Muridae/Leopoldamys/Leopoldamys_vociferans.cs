namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Leopoldamys;

/// <summary>
/// Species: Leopoldamys vociferans
/// NCBI TaxId: 1325302
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leopoldamys_vociferans : Leopoldamys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leopoldamys vociferans";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leopoldamys_vociferans";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1325302;
}
