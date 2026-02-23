namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae.Amphilius;

/// <summary>
/// Species: Amphilius sp. 'Malawi'
/// NCBI TaxId: 1572048
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amphilius_sp_Malawi : Amphilius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amphilius sp. 'Malawi'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amphilius_sp_Malawi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1572048;
}
