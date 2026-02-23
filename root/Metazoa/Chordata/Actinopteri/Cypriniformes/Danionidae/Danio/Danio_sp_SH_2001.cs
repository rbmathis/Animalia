namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Danio;

/// <summary>
/// Species: Danio sp. SH-2001
/// NCBI TaxId: 181617
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Danio_sp_SH_2001 : Danio
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Danio sp. SH-2001";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Danio_sp_SH_2001";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 181617;
}
