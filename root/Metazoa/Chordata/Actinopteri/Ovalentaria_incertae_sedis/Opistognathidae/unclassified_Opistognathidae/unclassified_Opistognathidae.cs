using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Opistognathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Opistognathidae.unclassified_Opistognathidae;

/// <summary>
/// Abstract class for unclassified Opistognathidae (no rank).
/// NCBI TaxId: 722548
/// </summary>
public abstract class unclassified_Opistognathidae : Opistognathidae, Iunclassified_Opistognathidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Opistognathidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 722548;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Opistognathidae";
}
