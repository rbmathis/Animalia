using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Cirrhinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Cirrhinus.unclassified_Cirrhinus;

/// <summary>
/// Abstract class for unclassified Cirrhinus (no rank).
/// NCBI TaxId: 2645500
/// </summary>
public abstract class unclassified_Cirrhinus : Cirrhinus, Iunclassified_Cirrhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cirrhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645500;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cirrhinus";
}
