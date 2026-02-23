namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Cyclemys;

/// <summary>
/// Species: Cyclemys sp. fusca x Cyclemys oldhamii
/// NCBI TaxId: 494920
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cyclemys_sp_fusca_x_Cyclemys_oldhamii : Cyclemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cyclemys sp. fusca x Cyclemys oldhamii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cyclemys_sp_fusca_x_Cyclemys_oldhamii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 494920;
}
