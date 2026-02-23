namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Rhinogobius;

/// <summary>
/// Species: Rhinogobius lentiginis
/// NCBI TaxId: 2920502
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhinogobius_lentiginis : Rhinogobius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhinogobius lentiginis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhinogobius_lentiginis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2920502;
}
