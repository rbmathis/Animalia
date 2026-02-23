namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Coturnix;

/// <summary>
/// Species: Coturnix japonica
/// NCBI TaxId: 93934
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coturnix_japonica : Coturnix
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coturnix japonica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coturnix_japonica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 93934;
}
