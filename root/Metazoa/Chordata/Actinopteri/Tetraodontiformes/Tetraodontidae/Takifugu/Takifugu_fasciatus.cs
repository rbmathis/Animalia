namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Takifugu;

/// <summary>
/// Species: Takifugu fasciatus
/// NCBI TaxId: 301270
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Takifugu_fasciatus : Takifugu
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Takifugu fasciatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Takifugu_fasciatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 301270;
}
