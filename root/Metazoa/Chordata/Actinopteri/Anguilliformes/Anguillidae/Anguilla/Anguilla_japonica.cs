namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Anguillidae.Anguilla;

/// <summary>
/// Species: Anguilla japonica
/// NCBI TaxId: 7937
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anguilla_japonica : Anguilla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anguilla japonica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anguilla_japonica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 7937;
}
