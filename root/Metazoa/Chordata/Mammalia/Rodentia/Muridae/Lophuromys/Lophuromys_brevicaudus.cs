namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Lophuromys;

/// <summary>
/// Species: Lophuromys brevicaudus
/// NCBI TaxId: 303927
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lophuromys_brevicaudus : Lophuromys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lophuromys brevicaudus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lophuromys_brevicaudus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 303927;
}
