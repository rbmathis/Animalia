namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Laemanctus;

/// <summary>
/// Species: Laemanctus longipes
/// NCBI TaxId: 211983
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Laemanctus_longipes : Laemanctus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Laemanctus longipes";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Laemanctus_longipes";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 211983;
}
