namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Anguillidae.Anguilla;

/// <summary>
/// Species: Anguilla dieffenbachii
/// NCBI TaxId: 61127
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anguilla_dieffenbachii : Anguilla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anguilla dieffenbachii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anguilla_dieffenbachii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 61127;
}
