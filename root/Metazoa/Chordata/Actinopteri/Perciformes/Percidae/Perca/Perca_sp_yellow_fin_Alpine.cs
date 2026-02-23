namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Perca;

/// <summary>
/// Species: Perca sp. 'yellow fin Alpine'
/// NCBI TaxId: 2874917
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Perca_sp_yellow_fin_Alpine : Perca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Perca sp. 'yellow fin Alpine'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Perca_sp_yellow_fin_Alpine";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2874917;
}
