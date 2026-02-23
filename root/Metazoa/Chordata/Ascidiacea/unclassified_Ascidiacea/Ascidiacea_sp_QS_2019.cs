namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.unclassified_Ascidiacea;

/// <summary>
/// Species: Ascidiacea sp. QS-2019
/// NCBI TaxId: 2567897
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ascidiacea_sp_QS_2019 : unclassified_Ascidiacea
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ascidiacea sp. QS-2019";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ascidiacea_sp_QS_2019";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2567897;
}
