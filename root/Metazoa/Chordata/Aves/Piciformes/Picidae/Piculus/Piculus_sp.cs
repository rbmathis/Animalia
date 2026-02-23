namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Piculus;

/// <summary>
/// Species: Piculus sp.
/// NCBI TaxId: 1333879
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Piculus_sp : Piculus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Piculus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Piculus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1333879;
}
