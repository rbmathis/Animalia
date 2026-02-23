namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.unclassified_Stolidobranchia;

/// <summary>
/// Species: Stolidobranchia sp.
/// NCBI TaxId: 3410513
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Stolidobranchia_sp : unclassified_Stolidobranchia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Stolidobranchia sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Stolidobranchia_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3410513;
}
