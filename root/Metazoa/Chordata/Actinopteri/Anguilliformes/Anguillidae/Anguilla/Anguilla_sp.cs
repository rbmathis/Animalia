namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Anguillidae.Anguilla;

/// <summary>
/// Species: Anguilla sp.
/// NCBI TaxId: 62126
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anguilla_sp : Anguilla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anguilla sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anguilla_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 62126;
}
