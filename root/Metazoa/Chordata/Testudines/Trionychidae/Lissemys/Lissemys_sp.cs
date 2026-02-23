namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Lissemys;

/// <summary>
/// Species: Lissemys sp.
/// NCBI TaxId: 2018679
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lissemys_sp : Lissemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lissemys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lissemys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2018679;
}
