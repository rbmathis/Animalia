namespace AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Petromyzontidae.Lampetra;

/// <summary>
/// Species: Lampetra alaskensis
/// NCBI TaxId: 682879
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lampetra_alaskensis : Lampetra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lampetra alaskensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lampetra_alaskensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 682879;
}
