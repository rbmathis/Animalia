namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae.Catostomus;

/// <summary>
/// Species: Catostomus sp. 'Salish'
/// NCBI TaxId: 151337
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Catostomus_sp_Salish : Catostomus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Catostomus sp. 'Salish'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Catostomus_sp_Salish";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 151337;
}
