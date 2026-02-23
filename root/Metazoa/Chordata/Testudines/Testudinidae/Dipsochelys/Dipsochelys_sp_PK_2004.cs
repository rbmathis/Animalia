namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Dipsochelys;

/// <summary>
/// Species: Dipsochelys sp. PK-2004
/// NCBI TaxId: 282225
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dipsochelys_sp_PK_2004 : Dipsochelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dipsochelys sp. PK-2004";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dipsochelys_sp_PK_2004";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 282225;
}
