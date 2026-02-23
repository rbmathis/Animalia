namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Ptilopachus;

/// <summary>
/// Species: Ptilopachus petrosus
/// NCBI TaxId: 388972
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ptilopachus_petrosus : Ptilopachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ptilopachus petrosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ptilopachus_petrosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 388972;
}
