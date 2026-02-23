namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Barbus;

/// <summary>
/// Species: Barbus sp. 'Genale River'
/// NCBI TaxId: 178578
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Barbus_sp_Genale_River : Barbus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Barbus sp. 'Genale River'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Barbus_sp_Genale_River";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 178578;
}
