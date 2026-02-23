namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ploceidae.Bubalornis;

/// <summary>
/// Species: Bubalornis albirostris
/// NCBI TaxId: 187419
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bubalornis_albirostris : Bubalornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bubalornis albirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bubalornis_albirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 187419;
}
