namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Sylvicapra;

/// <summary>
/// Species: Sylvicapra grimmia
/// NCBI TaxId: 119562
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sylvicapra_grimmia : Sylvicapra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sylvicapra grimmia";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sylvicapra_grimmia";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 119562;
}
