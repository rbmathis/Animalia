namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae.Penelope;

/// <summary>
/// Species: Penelope pileata
/// NCBI TaxId: 1118817
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Penelope_pileata : Penelope
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Penelope pileata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Penelope_pileata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1118817;
}
