namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Perca;

/// <summary>
/// Species: Perca sp. BD-2002
/// NCBI TaxId: 195628
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Perca_sp_BD_2002 : Perca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Perca sp. BD-2002";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Perca_sp_BD_2002";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 195628;
}
