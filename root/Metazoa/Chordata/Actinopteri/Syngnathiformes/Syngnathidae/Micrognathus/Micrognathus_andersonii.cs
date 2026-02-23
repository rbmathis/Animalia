namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Micrognathus;

/// <summary>
/// Species: Micrognathus andersonii
/// NCBI TaxId: 1914730
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Micrognathus_andersonii : Micrognathus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Micrognathus andersonii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Micrognathus_andersonii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1914730;
}
