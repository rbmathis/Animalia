using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Claea;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Claea.unclassified_Claea;

/// <summary>
/// Abstract class for unclassified Claea (no rank).
/// NCBI TaxId: 3142543
/// </summary>
public abstract class unclassified_Claea : Claea, Iunclassified_Claea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Claea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3142543;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Claea";
}
