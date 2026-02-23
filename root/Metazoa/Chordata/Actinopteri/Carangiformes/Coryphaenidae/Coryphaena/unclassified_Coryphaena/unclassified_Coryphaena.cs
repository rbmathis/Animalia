using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Coryphaenidae.Coryphaena;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Coryphaenidae.Coryphaena.unclassified_Coryphaena;

/// <summary>
/// Abstract class for unclassified Coryphaena (no rank).
/// NCBI TaxId: 2636927
/// </summary>
public abstract class unclassified_Coryphaena : Coryphaena, Iunclassified_Coryphaena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Coryphaena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636927;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Coryphaena";
}
