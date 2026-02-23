namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dasyornithidae.Dasyornis;

/// <summary>
/// Species: Dasyornis longirostris
/// NCBI TaxId: 1930950
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dasyornis_longirostris : Dasyornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dasyornis longirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dasyornis_longirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1930950;
}
