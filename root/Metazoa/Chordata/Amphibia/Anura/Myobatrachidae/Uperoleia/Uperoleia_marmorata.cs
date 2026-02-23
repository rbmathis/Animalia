namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae.Uperoleia;

/// <summary>
/// Species: Uperoleia marmorata
/// NCBI TaxId: 8367
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Uperoleia_marmorata : Uperoleia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Uperoleia marmorata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Uperoleia_marmorata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8367;
}
