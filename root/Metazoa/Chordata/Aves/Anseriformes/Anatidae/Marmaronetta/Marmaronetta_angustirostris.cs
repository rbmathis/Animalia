namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Marmaronetta;

/// <summary>
/// Species: Marmaronetta angustirostris
/// NCBI TaxId: 75875
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Marmaronetta_angustirostris : Marmaronetta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Marmaronetta angustirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Marmaronetta_angustirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 75875;
}
