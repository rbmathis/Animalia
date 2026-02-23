namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Danio;

/// <summary>
/// Species: Danio rerio
/// NCBI TaxId: 7955
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Danio_rerio : Danio
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Danio rerio";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Danio_rerio";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 7955;
}
