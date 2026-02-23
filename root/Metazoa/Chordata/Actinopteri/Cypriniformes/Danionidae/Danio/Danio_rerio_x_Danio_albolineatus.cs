namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Danio;

/// <summary>
/// Species: Danio rerio x Danio albolineatus
/// NCBI TaxId: 3684156
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Danio_rerio_x_Danio_albolineatus : Danio
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Danio rerio x Danio albolineatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Danio_rerio_x_Danio_albolineatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3684156;
}
