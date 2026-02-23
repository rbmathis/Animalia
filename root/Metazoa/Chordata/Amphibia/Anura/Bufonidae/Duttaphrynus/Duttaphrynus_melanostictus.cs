namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Duttaphrynus;

/// <summary>
/// Species: Duttaphrynus melanostictus
/// NCBI TaxId: 30335
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Duttaphrynus_melanostictus : Duttaphrynus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Duttaphrynus melanostictus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Duttaphrynus_melanostictus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30335;
}
