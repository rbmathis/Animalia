namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Mareca;

/// <summary>
/// Species: Mareca falcata
/// NCBI TaxId: 75844
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mareca_falcata : Mareca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mareca falcata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mareca_falcata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 75844;
}
