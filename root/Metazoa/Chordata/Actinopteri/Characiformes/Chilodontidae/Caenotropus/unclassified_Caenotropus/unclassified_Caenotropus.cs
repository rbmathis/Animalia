using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Chilodontidae.Caenotropus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Chilodontidae.Caenotropus.unclassified_Caenotropus;

/// <summary>
/// Abstract class for unclassified Caenotropus (no rank).
/// NCBI TaxId: 3101821
/// </summary>
public abstract class unclassified_Caenotropus : Caenotropus, Iunclassified_Caenotropus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Caenotropus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3101821;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Caenotropus";
}
