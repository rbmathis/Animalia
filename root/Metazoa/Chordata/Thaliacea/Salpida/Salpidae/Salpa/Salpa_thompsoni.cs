namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae.Salpa;

/// <summary>
/// Species: Salpa thompsoni
/// NCBI TaxId: 569448
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Salpa_thompsoni : Salpa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Salpa thompsoni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Salpa_thompsoni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 569448;
}
