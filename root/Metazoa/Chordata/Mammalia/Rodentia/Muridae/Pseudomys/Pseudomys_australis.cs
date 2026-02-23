namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Pseudomys;

/// <summary>
/// Species: Pseudomys australis
/// NCBI TaxId: 187268
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pseudomys_australis : Pseudomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pseudomys australis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pseudomys_australis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 187268;
}
