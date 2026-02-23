namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Mitrephanes;

/// <summary>
/// Species: Mitrephanes olivaceus
/// NCBI TaxId: 183543
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mitrephanes_olivaceus : Mitrephanes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mitrephanes olivaceus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mitrephanes_olivaceus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 183543;
}
