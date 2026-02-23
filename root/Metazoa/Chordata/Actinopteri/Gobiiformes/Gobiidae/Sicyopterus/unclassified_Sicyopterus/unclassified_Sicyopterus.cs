using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Sicyopterus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Sicyopterus.unclassified_Sicyopterus;

/// <summary>
/// Abstract class for unclassified Sicyopterus (no rank).
/// NCBI TaxId: 2618588
/// </summary>
public abstract class unclassified_Sicyopterus : Sicyopterus, Iunclassified_Sicyopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sicyopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618588;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sicyopterus";
}
