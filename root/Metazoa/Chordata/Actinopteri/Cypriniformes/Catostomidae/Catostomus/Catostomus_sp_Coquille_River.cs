namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae.Catostomus;

/// <summary>
/// Species: Catostomus sp. 'Coquille River'
/// NCBI TaxId: 1338618
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Catostomus_sp_Coquille_River : Catostomus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Catostomus sp. 'Coquille River'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Catostomus_sp_Coquille_River";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1338618;
}
