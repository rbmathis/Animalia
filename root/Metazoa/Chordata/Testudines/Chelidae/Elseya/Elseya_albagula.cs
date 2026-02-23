namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Elseya;

/// <summary>
/// Species: Elseya albagula
/// NCBI TaxId: 904184
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Elseya_albagula : Elseya
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Elseya albagula";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Elseya_albagula";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 904184;
}
