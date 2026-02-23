using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Diaphus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Diaphus.unclassified_Diaphus;

/// <summary>
/// Abstract class for unclassified Diaphus (no rank).
/// NCBI TaxId: 2634043
/// </summary>
public abstract class unclassified_Diaphus : Diaphus, Iunclassified_Diaphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Diaphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634043;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Diaphus";
}
