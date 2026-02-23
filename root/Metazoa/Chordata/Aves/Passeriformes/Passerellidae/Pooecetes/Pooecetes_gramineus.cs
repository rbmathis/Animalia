namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Pooecetes;

/// <summary>
/// Species: Pooecetes gramineus
/// NCBI TaxId: 198943
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pooecetes_gramineus : Pooecetes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pooecetes gramineus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pooecetes_gramineus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 198943;
}
