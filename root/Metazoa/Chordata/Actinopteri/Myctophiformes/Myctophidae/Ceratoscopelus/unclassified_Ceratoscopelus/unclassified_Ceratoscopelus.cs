using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Ceratoscopelus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Ceratoscopelus.unclassified_Ceratoscopelus;

/// <summary>
/// Abstract class for unclassified Ceratoscopelus (no rank).
/// NCBI TaxId: 2623926
/// </summary>
public abstract class unclassified_Ceratoscopelus : Ceratoscopelus, Iunclassified_Ceratoscopelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ceratoscopelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623926;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ceratoscopelus";
}
