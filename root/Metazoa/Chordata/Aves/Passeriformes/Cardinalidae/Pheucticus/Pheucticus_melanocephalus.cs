namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae.Pheucticus;

/// <summary>
/// Species: Pheucticus melanocephalus
/// NCBI TaxId: 371919
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pheucticus_melanocephalus : Pheucticus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pheucticus melanocephalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pheucticus_melanocephalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 371919;
}
