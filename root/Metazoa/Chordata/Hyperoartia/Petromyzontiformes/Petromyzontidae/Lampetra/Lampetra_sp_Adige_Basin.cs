namespace AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Petromyzontidae.Lampetra;

/// <summary>
/// Species: Lampetra sp. 'Adige Basin'
/// NCBI TaxId: 1205711
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lampetra_sp_Adige_Basin : Lampetra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lampetra sp. 'Adige Basin'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lampetra_sp_Adige_Basin";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1205711;
}
