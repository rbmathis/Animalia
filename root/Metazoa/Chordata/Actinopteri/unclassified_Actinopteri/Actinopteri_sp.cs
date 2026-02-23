namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.unclassified_Actinopteri;

/// <summary>
/// Species: Actinopteri sp.
/// NCBI TaxId: 3063546
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Actinopteri_sp : unclassified_Actinopteri
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Actinopteri sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Actinopteri_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3063546;
}
