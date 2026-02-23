namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Gallus;

/// <summary>
/// Species: Gallus varius
/// NCBI TaxId: 9034
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gallus_varius : Gallus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gallus varius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gallus_varius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9034;
}
