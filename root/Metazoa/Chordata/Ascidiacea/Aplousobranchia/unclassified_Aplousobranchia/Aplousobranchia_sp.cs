namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.unclassified_Aplousobranchia;

/// <summary>
/// Species: Aplousobranchia sp.
/// NCBI TaxId: 3410514
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aplousobranchia_sp : unclassified_Aplousobranchia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aplousobranchia sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aplousobranchia_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3410514;
}
