namespace AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Petromyzontidae.Lampetra;

/// <summary>
/// Species: Lampetra sp. KM-1999
/// NCBI TaxId: 1138765
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lampetra_sp_KM_1999 : Lampetra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lampetra sp. KM-1999";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lampetra_sp_KM_1999";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1138765;
}
