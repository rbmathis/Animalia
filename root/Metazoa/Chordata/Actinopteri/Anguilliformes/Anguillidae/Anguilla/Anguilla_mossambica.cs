namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Anguillidae.Anguilla;

/// <summary>
/// Species: Anguilla mossambica
/// NCBI TaxId: 48164
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anguilla_mossambica : Anguilla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anguilla mossambica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anguilla_mossambica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 48164;
}
