namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Gallus;

/// <summary>
/// Species: Gallus gallus
/// NCBI TaxId: 9031
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gallus_gallus : Gallus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gallus gallus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gallus_gallus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9031;
}
