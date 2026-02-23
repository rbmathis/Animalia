namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Carassius;

/// <summary>
/// Species: Carassius sp. 'Ginbuna'
/// NCBI TaxId: 2709305
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Carassius_sp_Ginbuna : Carassius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Carassius sp. 'Ginbuna'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Carassius_sp_Ginbuna";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2709305;
}
