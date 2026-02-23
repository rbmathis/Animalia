namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Gobio;

/// <summary>
/// Species: Gobio sp. TP-2013
/// NCBI TaxId: 1340823
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gobio_sp_TP_2013 : Gobio
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gobio sp. TP-2013";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gobio_sp_TP_2013";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1340823;
}
