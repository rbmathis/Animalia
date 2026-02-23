namespace AnimalKingdom.root.Metazoa.Chordata.Myxini.Myxiniformes.Myxinidae.Myxine;

/// <summary>
/// Species: Myxine glutinosa
/// NCBI TaxId: 7769
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myxine_glutinosa : Myxine
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myxine glutinosa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myxine_glutinosa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 7769;
}
