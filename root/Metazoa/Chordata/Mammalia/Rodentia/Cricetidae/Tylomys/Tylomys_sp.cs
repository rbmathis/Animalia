namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Tylomys;

/// <summary>
/// Species: Tylomys sp.
/// NCBI TaxId: 164613
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tylomys_sp : Tylomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tylomys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tylomys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 164613;
}
