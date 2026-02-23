namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Dipsochelys;

/// <summary>
/// Species: Dipsochelys arnoldi
/// NCBI TaxId: 175474
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dipsochelys_arnoldi : Dipsochelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dipsochelys arnoldi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dipsochelys_arnoldi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 175474;
}
