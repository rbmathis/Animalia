namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Aix;

/// <summary>
/// Species: Aix sp.
/// NCBI TaxId: 8834
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aix_sp : Aix
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aix sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aix_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8834;
}
