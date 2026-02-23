namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Mauremys;

/// <summary>
/// Species: Mauremys leprosa
/// NCBI TaxId: 176197
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mauremys_leprosa : Mauremys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mauremys leprosa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mauremys_leprosa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 176197;
}
