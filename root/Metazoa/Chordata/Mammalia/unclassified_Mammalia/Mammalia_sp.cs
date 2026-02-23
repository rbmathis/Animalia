namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.unclassified_Mammalia;

/// <summary>
/// Species: Mammalia sp.
/// NCBI TaxId: 3375807
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mammalia_sp : unclassified_Mammalia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mammalia sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mammalia_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3375807;
}
