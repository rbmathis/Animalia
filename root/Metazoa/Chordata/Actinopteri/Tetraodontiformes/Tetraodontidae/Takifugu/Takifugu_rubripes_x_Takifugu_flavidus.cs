namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Takifugu;

/// <summary>
/// Species: Takifugu rubripes x Takifugu flavidus
/// NCBI TaxId: 1233031
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Takifugu_rubripes_x_Takifugu_flavidus : Takifugu
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Takifugu rubripes x Takifugu flavidus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Takifugu_rubripes_x_Takifugu_flavidus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1233031;
}
