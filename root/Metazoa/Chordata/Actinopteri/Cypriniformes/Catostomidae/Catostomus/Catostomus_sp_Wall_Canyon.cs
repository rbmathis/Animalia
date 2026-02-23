namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae.Catostomus;

/// <summary>
/// Species: Catostomus sp. 'Wall Canyon'
/// NCBI TaxId: 244771
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Catostomus_sp_Wall_Canyon : Catostomus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Catostomus sp. 'Wall Canyon'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Catostomus_sp_Wall_Canyon";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 244771;
}
