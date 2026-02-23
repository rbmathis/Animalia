namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Gasterosteidae.Gasterosteus;

/// <summary>
/// Species: Gasterosteus aculeatus x Gasterosteus nipponicus
/// NCBI TaxId: 2125979
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gasterosteus_aculeatus_x_Gasterosteus_nipponicus : Gasterosteus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gasterosteus aculeatus x Gasterosteus nipponicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gasterosteus_aculeatus_x_Gasterosteus_nipponicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2125979;
}
