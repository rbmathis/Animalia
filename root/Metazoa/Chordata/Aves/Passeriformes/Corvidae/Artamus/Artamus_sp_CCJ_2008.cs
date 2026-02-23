namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Artamus;

/// <summary>
/// Species: Artamus sp. CCJ-2008
/// NCBI TaxId: 585475
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Artamus_sp_CCJ_2008 : Artamus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Artamus sp. CCJ-2008";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Artamus_sp_CCJ_2008";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 585475;
}
