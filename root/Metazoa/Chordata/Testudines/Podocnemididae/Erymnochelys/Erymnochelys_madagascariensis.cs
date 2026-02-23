namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Podocnemididae.Erymnochelys;

/// <summary>
/// Species: Erymnochelys madagascariensis
/// NCBI TaxId: 44520
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Erymnochelys_madagascariensis : Erymnochelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Erymnochelys madagascariensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Erymnochelys_madagascariensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 44520;
}
