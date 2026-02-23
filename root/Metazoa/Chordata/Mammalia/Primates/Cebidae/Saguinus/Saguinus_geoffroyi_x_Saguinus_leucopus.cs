namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Saguinus;

/// <summary>
/// Species: Saguinus geoffroyi x Saguinus leucopus
/// NCBI TaxId: 2586293
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Saguinus_geoffroyi_x_Saguinus_leucopus : Saguinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Saguinus geoffroyi x Saguinus leucopus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Saguinus_geoffroyi_x_Saguinus_leucopus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2586293;
}
