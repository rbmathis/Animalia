namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Spelaeornis;

/// <summary>
/// Species: Spelaeornis oatesi
/// NCBI TaxId: 2485309
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Spelaeornis_oatesi : Spelaeornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Spelaeornis oatesi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Spelaeornis_oatesi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2485309;
}
