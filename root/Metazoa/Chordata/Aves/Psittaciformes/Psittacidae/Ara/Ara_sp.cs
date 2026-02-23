namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Ara;

/// <summary>
/// Species: Ara sp.
/// NCBI TaxId: 1661782
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ara_sp : Ara
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ara sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ara_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1661782;
}
