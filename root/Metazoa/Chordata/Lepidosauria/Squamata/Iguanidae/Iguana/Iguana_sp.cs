namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Iguana;

/// <summary>
/// Species: Iguana sp.
/// NCBI TaxId: 2590125
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Iguana_sp : Iguana
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Iguana sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Iguana_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2590125;
}
