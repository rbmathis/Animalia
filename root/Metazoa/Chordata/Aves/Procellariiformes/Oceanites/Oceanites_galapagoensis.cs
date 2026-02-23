namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Oceanites;

/// <summary>
/// Species: Oceanites galapagoensis
/// NCBI TaxId: 1112095
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oceanites_galapagoensis : Oceanites
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oceanites galapagoensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oceanites_galapagoensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1112095;
}
