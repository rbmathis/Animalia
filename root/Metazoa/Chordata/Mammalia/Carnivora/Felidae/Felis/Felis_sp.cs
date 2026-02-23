namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Felis;

/// <summary>
/// Species: Felis sp.
/// NCBI TaxId: 9687
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Felis_sp : Felis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Felis sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Felis_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9687;
}
