namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.unclassified_Sylvioidea;

/// <summary>
/// Species: Sylvioidea sp.
/// NCBI TaxId: 2661690
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sylvioidea_sp : unclassified_Sylvioidea
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sylvioidea sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sylvioidea_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2661690;
}
