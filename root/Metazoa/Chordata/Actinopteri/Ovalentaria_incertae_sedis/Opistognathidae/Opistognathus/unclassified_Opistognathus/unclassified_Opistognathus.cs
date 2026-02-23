using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Opistognathidae.Opistognathus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Opistognathidae.Opistognathus.unclassified_Opistognathus;

/// <summary>
/// Abstract class for unclassified Opistognathus (no rank).
/// NCBI TaxId: 2634677
/// </summary>
public abstract class unclassified_Opistognathus : Opistognathus, Iunclassified_Opistognathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Opistognathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634677;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Opistognathus";
}
