using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Clavelinidae.Clavelina;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Clavelinidae.Clavelina.unclassified_Clavelina;

/// <summary>
/// Abstract class for unclassified Clavelina (no rank).
/// NCBI TaxId: 2645683
/// </summary>
public abstract class unclassified_Clavelina : Clavelina, Iunclassified_Clavelina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Clavelina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645683;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Clavelina";
}
