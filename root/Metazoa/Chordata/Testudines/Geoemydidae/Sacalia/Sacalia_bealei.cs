namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Sacalia;

/// <summary>
/// Species: Sacalia bealei
/// NCBI TaxId: 204942
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sacalia_bealei : Sacalia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sacalia bealei";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sacalia_bealei";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 204942;
}
