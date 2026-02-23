using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Ptychochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Ptychochromis.unclassified_Ptychochromis;

/// <summary>
/// Abstract class for unclassified Ptychochromis (no rank).
/// NCBI TaxId: 2632074
/// </summary>
public abstract class unclassified_Ptychochromis : Ptychochromis, Iunclassified_Ptychochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ptychochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632074;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ptychochromis";
}
