namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae.Uperoleia;

/// <summary>
/// Species: Uperoleia borealis
/// NCBI TaxId: 1104367
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Uperoleia_borealis : Uperoleia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Uperoleia borealis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Uperoleia_borealis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1104367;
}
