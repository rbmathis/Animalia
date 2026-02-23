namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Danio;

/// <summary>
/// Species: Danio sp. SSH-2005
/// NCBI TaxId: 342435
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Danio_sp_SSH_2005 : Danio
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Danio sp. SSH-2005";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Danio_sp_SSH_2005";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 342435;
}
