using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Ophichthus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Ophichthus.unclassified_Ophichthus;

/// <summary>
/// Abstract class for unclassified Ophichthus (no rank).
/// NCBI TaxId: 2618225
/// </summary>
public abstract class unclassified_Ophichthus : Ophichthus, Iunclassified_Ophichthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ophichthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618225;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ophichthus";
}
