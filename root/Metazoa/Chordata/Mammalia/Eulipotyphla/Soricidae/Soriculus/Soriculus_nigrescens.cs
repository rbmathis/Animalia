namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Soriculus;

/// <summary>
/// Species: Soriculus nigrescens
/// NCBI TaxId: 62296
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Soriculus_nigrescens : Soriculus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Soriculus nigrescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Soriculus_nigrescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 62296;
}
