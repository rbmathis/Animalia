namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Trachemys;

/// <summary>
/// Species: Trachemys scripta
/// NCBI TaxId: 34903
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trachemys_scripta : Trachemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trachemys scripta";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trachemys_scripta";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 34903;
}
