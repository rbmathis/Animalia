namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Coregonus;

/// <summary>
/// Species: Coregonus fluviatilis
/// NCBI TaxId: 1935467
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coregonus_fluviatilis : Coregonus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coregonus fluviatilis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coregonus_fluviatilis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1935467;
}
