using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Hoplobrotula;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Hoplobrotula.unclassified_Hoplobrotula;

/// <summary>
/// Abstract class for unclassified Hoplobrotula (no rank).
/// NCBI TaxId: 3095281
/// </summary>
public abstract class unclassified_Hoplobrotula : Hoplobrotula, Iunclassified_Hoplobrotula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hoplobrotula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3095281;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hoplobrotula";
}
