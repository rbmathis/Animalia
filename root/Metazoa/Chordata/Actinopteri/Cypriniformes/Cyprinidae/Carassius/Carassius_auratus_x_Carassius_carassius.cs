namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Carassius;

/// <summary>
/// Species: Carassius auratus x Carassius carassius
/// NCBI TaxId: 1392537
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Carassius_auratus_x_Carassius_carassius : Carassius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Carassius auratus x Carassius carassius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Carassius_auratus_x_Carassius_carassius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1392537;
}
