namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Papagomys;

/// <summary>
/// Species: Papagomys armandvillei
/// NCBI TaxId: 2716773
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Papagomys_armandvillei : Papagomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Papagomys armandvillei";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Papagomys_armandvillei";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2716773;
}
