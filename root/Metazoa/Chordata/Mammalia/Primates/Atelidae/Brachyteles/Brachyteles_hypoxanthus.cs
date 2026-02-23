namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae.Brachyteles;

/// <summary>
/// Species: Brachyteles hypoxanthus
/// NCBI TaxId: 342807
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Brachyteles_hypoxanthus : Brachyteles
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Brachyteles hypoxanthus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Brachyteles_hypoxanthus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 342807;
}
