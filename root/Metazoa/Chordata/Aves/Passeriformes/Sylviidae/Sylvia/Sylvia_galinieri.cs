namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Sylvia;

/// <summary>
/// Species: Sylvia galinieri
/// NCBI TaxId: 3150601
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sylvia_galinieri : Sylvia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sylvia galinieri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sylvia_galinieri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3150601;
}
