namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Euneornis;

/// <summary>
/// Species: Euneornis campestris
/// NCBI TaxId: 200194
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Euneornis_campestris : Euneornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Euneornis campestris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Euneornis_campestris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 200194;
}
