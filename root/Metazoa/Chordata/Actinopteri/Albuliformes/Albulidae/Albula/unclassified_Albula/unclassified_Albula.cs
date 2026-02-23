using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Albuliformes.Albulidae.Albula;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Albuliformes.Albulidae.Albula.unclassified_Albula;

/// <summary>
/// Abstract class for unclassified Albula (no rank).
/// NCBI TaxId: 2648096
/// </summary>
public abstract class unclassified_Albula : Albula, Iunclassified_Albula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Albula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648096;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Albula";
}
