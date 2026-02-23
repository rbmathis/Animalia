namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae.Amphilius;

/// <summary>
/// Species: Amphilius sp. 'Lake Rukwa'
/// NCBI TaxId: 1572047
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amphilius_sp_Lake_Rukwa : Amphilius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amphilius sp. 'Lake Rukwa'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amphilius_sp_Lake_Rukwa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1572047;
}
