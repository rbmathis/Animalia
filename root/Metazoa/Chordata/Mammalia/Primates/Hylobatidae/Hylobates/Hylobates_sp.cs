namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hylobatidae.Hylobates;

/// <summary>
/// Species: Hylobates sp.
/// NCBI TaxId: 9581
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hylobates_sp : Hylobates
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hylobates sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hylobates_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9581;
}
