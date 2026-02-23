namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Gallus;

/// <summary>
/// Species: Gallus sp.
/// NCBI TaxId: 9036
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gallus_sp : Gallus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gallus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gallus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9036;
}
