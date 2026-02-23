namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Elseya;

/// <summary>
/// Species: Elseya dentata
/// NCBI TaxId: 44497
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Elseya_dentata : Elseya
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Elseya dentata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Elseya_dentata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 44497;
}
