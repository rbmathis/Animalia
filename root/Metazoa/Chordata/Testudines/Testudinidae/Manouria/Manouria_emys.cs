namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Manouria;

/// <summary>
/// Species: Manouria emys
/// NCBI TaxId: 260614
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Manouria_emys : Manouria
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Manouria emys";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Manouria_emys";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 260614;
}
