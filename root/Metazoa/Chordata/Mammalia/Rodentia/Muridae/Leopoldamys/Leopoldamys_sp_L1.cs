namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Leopoldamys;

/// <summary>
/// Species: Leopoldamys sp. L1
/// NCBI TaxId: 1480181
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leopoldamys_sp_L1 : Leopoldamys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leopoldamys sp. L1";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leopoldamys_sp_L1";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1480181;
}
