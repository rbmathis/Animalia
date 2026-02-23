namespace AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Petromyzontidae.Lampetra;

/// <summary>
/// Species: Lampetra sp.
/// NCBI TaxId: 94973
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lampetra_sp : Lampetra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lampetra sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lampetra_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 94973;
}
