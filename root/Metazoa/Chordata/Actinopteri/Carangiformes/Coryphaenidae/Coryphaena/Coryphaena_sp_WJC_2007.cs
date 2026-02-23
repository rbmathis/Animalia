namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Coryphaenidae.Coryphaena;

/// <summary>
/// Species: Coryphaena sp. WJC-2007
/// NCBI TaxId: 435270
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coryphaena_sp_WJC_2007 : Coryphaena
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coryphaena sp. WJC-2007";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coryphaena_sp_WJC_2007";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 435270;
}
