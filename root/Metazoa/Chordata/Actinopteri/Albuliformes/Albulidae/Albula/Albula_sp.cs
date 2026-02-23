namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Albuliformes.Albulidae.Albula;

/// <summary>
/// Species: Albula sp.
/// NCBI TaxId: 3456242
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Albula_sp : Albula
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Albula sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Albula_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3456242;
}
