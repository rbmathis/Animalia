namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vireonidae.Vireo;

/// <summary>
/// Species: Vireo olivaceus
/// NCBI TaxId: 28733
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vireo_olivaceus : Vireo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vireo olivaceus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vireo_olivaceus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 28733;
}
