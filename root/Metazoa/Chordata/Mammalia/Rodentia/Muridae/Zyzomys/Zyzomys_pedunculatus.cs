namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Zyzomys;

/// <summary>
/// Species: Zyzomys pedunculatus
/// NCBI TaxId: 442625
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Zyzomys_pedunculatus : Zyzomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Zyzomys pedunculatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Zyzomys_pedunculatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 442625;
}
