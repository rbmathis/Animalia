namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae.Crax;

/// <summary>
/// Species: Crax daubentoni
/// NCBI TaxId: 84986
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Crax_daubentoni : Crax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Crax daubentoni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Crax_daubentoni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 84986;
}
