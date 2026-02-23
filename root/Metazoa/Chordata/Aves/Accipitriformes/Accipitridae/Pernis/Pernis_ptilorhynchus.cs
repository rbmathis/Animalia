namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Pernis;

/// <summary>
/// Species: Pernis ptilorhynchus
/// NCBI TaxId: 258802
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pernis_ptilorhynchus : Pernis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pernis ptilorhynchus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pernis_ptilorhynchus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 258802;
}
