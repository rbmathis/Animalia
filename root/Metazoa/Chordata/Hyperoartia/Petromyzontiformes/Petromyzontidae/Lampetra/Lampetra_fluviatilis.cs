namespace AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Petromyzontidae.Lampetra;

/// <summary>
/// Species: Lampetra fluviatilis
/// NCBI TaxId: 7748
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lampetra_fluviatilis : Lampetra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lampetra fluviatilis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lampetra_fluviatilis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 7748;
}
