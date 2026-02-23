namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Branta;

/// <summary>
/// Species: Branta sp.
/// NCBI TaxId: 3435963
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Branta_sp : Branta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Branta sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Branta_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3435963;
}
