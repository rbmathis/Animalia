namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squatinidae.Squatina;

/// <summary>
/// Species: Squatina sp. VP-2012
/// NCBI TaxId: 1196300
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squatina_sp_VP_2012 : Squatina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squatina sp. VP-2012";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squatina_sp_VP_2012";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1196300;
}
