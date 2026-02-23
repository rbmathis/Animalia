namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.unclassified_Elasmobranchii;

/// <summary>
/// Species: unidentified dogfish
/// NCBI TaxId: 641952
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class unidentified_dogfish : unclassified_Elasmobranchii
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "unidentified dogfish";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "unidentified_dogfish";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 641952;
}
