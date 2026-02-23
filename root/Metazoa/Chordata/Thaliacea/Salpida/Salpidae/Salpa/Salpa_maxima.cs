namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae.Salpa;

/// <summary>
/// Species: Salpa maxima
/// NCBI TaxId: 942555
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Salpa_maxima : Salpa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Salpa maxima";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Salpa_maxima";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 942555;
}
