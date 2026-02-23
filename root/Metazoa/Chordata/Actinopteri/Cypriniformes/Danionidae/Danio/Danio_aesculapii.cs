namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Danio;

/// <summary>
/// Species: Danio aesculapii
/// NCBI TaxId: 1142201
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Danio_aesculapii : Danio
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Danio aesculapii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Danio_aesculapii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1142201;
}
