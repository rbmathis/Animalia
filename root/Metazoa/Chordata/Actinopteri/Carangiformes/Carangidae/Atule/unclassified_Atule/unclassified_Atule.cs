using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Atule;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Atule.unclassified_Atule;

/// <summary>
/// Abstract class for unclassified Atule (no rank).
/// NCBI TaxId: 2990149
/// </summary>
public abstract class unclassified_Atule : Atule, Iunclassified_Atule
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Atule";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2990149;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Atule";
}
