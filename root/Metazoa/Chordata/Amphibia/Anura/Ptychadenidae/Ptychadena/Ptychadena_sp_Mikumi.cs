namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ptychadenidae.Ptychadena;

/// <summary>
/// Species: Ptychadena sp. 'Mikumi'
/// NCBI TaxId: 383851
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ptychadena_sp_Mikumi : Ptychadena
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ptychadena sp. 'Mikumi'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ptychadena_sp_Mikumi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 383851;
}
