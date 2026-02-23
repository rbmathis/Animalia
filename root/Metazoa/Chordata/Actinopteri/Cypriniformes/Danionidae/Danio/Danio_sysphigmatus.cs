namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Danio;

/// <summary>
/// Species: Danio sysphigmatus
/// NCBI TaxId: 1699791
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Danio_sysphigmatus : Danio
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Danio sysphigmatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Danio_sysphigmatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1699791;
}
