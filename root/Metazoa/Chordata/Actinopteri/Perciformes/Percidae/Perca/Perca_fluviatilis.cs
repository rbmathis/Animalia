namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Perca;

/// <summary>
/// Species: Perca fluviatilis
/// NCBI TaxId: 8168
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Perca_fluviatilis : Perca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Perca fluviatilis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Perca_fluviatilis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8168;
}
