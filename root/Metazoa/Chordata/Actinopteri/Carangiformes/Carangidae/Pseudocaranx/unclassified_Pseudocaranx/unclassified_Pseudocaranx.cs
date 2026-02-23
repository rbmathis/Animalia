using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Pseudocaranx;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Pseudocaranx.unclassified_Pseudocaranx;

/// <summary>
/// Abstract class for unclassified Pseudocaranx (no rank).
/// NCBI TaxId: 2850096
/// </summary>
public abstract class unclassified_Pseudocaranx : Pseudocaranx, Iunclassified_Pseudocaranx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudocaranx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2850096;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudocaranx";
}
