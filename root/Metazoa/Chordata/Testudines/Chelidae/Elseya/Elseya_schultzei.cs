namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Elseya;

/// <summary>
/// Species: Elseya schultzei
/// NCBI TaxId: 2080844
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Elseya_schultzei : Elseya
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Elseya schultzei";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Elseya_schultzei";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2080844;
}
