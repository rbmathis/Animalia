namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Danio;

/// <summary>
/// Species: Danio sp.
/// NCBI TaxId: 61251
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Danio_sp : Danio
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Danio sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Danio_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 61251;
}
