namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae.Amphilius;

/// <summary>
/// Species: Amphilius sp. 'S. Africa'
/// NCBI TaxId: 1572054
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amphilius_sp_S_Africa : Amphilius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amphilius sp. 'S. Africa'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amphilius_sp_S_Africa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1572054;
}
