namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Kerivoula;

/// <summary>
/// Species: Kerivoula cuprosa
/// NCBI TaxId: 1987007
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Kerivoula_cuprosa : Kerivoula
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Kerivoula cuprosa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Kerivoula_cuprosa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1987007;
}
