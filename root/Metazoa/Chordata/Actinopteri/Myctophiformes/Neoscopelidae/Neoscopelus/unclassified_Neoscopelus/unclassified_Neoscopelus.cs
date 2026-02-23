using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Neoscopelidae.Neoscopelus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Neoscopelidae.Neoscopelus.unclassified_Neoscopelus;

/// <summary>
/// Abstract class for unclassified Neoscopelus (no rank).
/// NCBI TaxId: 3133149
/// </summary>
public abstract class unclassified_Neoscopelus : Neoscopelus, Iunclassified_Neoscopelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neoscopelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3133149;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neoscopelus";
}
