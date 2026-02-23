namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Mesalina;

/// <summary>
/// Species: Mesalina sp. 'Kuri'
/// NCBI TaxId: 162268
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mesalina_sp_Kuri : Mesalina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mesalina sp. 'Kuri'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mesalina_sp_Kuri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 162268;
}
