namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Rypticus;

/// <summary>
/// Species: Rypticus subbifrenatus
/// NCBI TaxId: 1110611
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rypticus_subbifrenatus : Rypticus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rypticus subbifrenatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rypticus_subbifrenatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1110611;
}
