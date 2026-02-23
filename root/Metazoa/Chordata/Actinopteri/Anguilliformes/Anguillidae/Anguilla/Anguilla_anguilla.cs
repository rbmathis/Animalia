namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Anguillidae.Anguilla;

/// <summary>
/// Species: Anguilla anguilla
/// NCBI TaxId: 7936
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anguilla_anguilla : Anguilla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anguilla anguilla";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anguilla_anguilla";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 7936;
}
