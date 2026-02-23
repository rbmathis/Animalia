namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Phaethornis;

/// <summary>
/// Species: Phaethornis longirostris
/// NCBI TaxId: 472904
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phaethornis_longirostris : Phaethornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phaethornis longirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phaethornis_longirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 472904;
}
