namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Danio;

/// <summary>
/// Species: Danio rerio x Danio aesculapii
/// NCBI TaxId: 2959342
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Danio_rerio_x_Danio_aesculapii : Danio
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Danio rerio x Danio aesculapii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Danio_rerio_x_Danio_aesculapii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2959342;
}
