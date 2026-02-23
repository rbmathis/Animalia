namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Dipsochelys;

/// <summary>
/// Species: Dipsochelys hololissa
/// NCBI TaxId: 174718
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dipsochelys_hololissa : Dipsochelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dipsochelys hololissa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dipsochelys_hololissa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 174718;
}
