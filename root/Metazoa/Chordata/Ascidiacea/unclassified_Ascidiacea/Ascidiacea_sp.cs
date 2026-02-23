namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.unclassified_Ascidiacea;

/// <summary>
/// Species: Ascidiacea sp.
/// NCBI TaxId: 70594
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ascidiacea_sp : unclassified_Ascidiacea
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ascidiacea sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ascidiacea_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 70594;
}
