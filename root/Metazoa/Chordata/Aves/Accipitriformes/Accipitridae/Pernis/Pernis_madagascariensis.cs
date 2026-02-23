namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Pernis;

/// <summary>
/// Species: Pernis madagascariensis
/// NCBI TaxId: 2868387
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pernis_madagascariensis : Pernis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pernis madagascariensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pernis_madagascariensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2868387;
}
