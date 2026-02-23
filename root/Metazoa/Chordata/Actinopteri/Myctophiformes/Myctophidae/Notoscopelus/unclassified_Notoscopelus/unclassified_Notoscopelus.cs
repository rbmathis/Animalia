using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Notoscopelus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Notoscopelus.unclassified_Notoscopelus;

/// <summary>
/// Abstract class for unclassified Notoscopelus (no rank).
/// NCBI TaxId: 2629157
/// </summary>
public abstract class unclassified_Notoscopelus : Notoscopelus, Iunclassified_Notoscopelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Notoscopelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629157;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Notoscopelus";
}
