namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Phasianidae_intergeneric_hybrids;

/// <summary>
/// Species: Gallus gallus x Coturnix coturnix
/// NCBI TaxId: 593244
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gallus_gallus_x_Coturnix_coturnix : Phasianidae_intergeneric_hybrids
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gallus gallus x Coturnix coturnix";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gallus_gallus_x_Coturnix_coturnix";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 593244;
}
