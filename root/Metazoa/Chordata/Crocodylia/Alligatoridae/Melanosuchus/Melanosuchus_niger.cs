namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Alligatoridae.Melanosuchus;

/// <summary>
/// Species: Melanosuchus niger
/// NCBI TaxId: 38656
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Melanosuchus_niger : Melanosuchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Melanosuchus niger";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Melanosuchus_niger";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 38656;
}
