namespace AnimalKingdom.root.Metazoa.Chordata.Myxini.Myxiniformes.Myxinidae.Myxine;

/// <summary>
/// Species: Myxine sp. 2 CHK-2001
/// NCBI TaxId: 180517
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myxine_sp_2_CHK_2001 : Myxine
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myxine sp. 2 CHK-2001";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myxine_sp_2_CHK_2001";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 180517;
}
