namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ploceidae.Anaplectes;

/// <summary>
/// Species: Anaplectes rubriceps
/// NCBI TaxId: 907500
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anaplectes_rubriceps : Anaplectes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anaplectes rubriceps";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anaplectes_rubriceps";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 907500;
}
