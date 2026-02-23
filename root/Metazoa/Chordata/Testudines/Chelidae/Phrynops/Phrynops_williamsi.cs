namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Phrynops;

/// <summary>
/// Species: Phrynops williamsi
/// NCBI TaxId: 241400
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phrynops_williamsi : Phrynops
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phrynops williamsi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phrynops_williamsi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 241400;
}
