namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

/// <summary>
/// Species: Columbidae sp.
/// NCBI TaxId: 2594101
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Columbidae_sp : Columbidae
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Columbidae sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Columbidae_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2594101;
}
