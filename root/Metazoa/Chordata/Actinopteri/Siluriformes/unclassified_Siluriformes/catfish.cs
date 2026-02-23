namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.unclassified_Siluriformes;

/// <summary>
/// Species: catfish
/// NCBI TaxId: 71179
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class catfish : unclassified_Siluriformes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "catfish";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "catfish";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 71179;
}
