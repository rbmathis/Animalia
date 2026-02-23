namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae.Ateles;

/// <summary>
/// Species: Ateles sp. Ate-1
/// NCBI TaxId: 2746757
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ateles_sp_Ate_1 : Ateles
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ateles sp. Ate-1";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ateles_sp_Ate_1";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2746757;
}
