namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Junco;

/// <summary>
/// Species: Junco sp. ZCMS001
/// NCBI TaxId: 2789766
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Junco_sp_ZCMS001 : Junco
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Junco sp. ZCMS001";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Junco_sp_ZCMS001";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2789766;
}
