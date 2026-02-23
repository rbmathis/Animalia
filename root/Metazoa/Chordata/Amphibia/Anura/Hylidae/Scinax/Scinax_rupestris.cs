namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Scinax;

/// <summary>
/// Species: Scinax rupestris
/// NCBI TaxId: 3045582
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scinax_rupestris : Scinax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scinax rupestris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scinax_rupestris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3045582;
}
