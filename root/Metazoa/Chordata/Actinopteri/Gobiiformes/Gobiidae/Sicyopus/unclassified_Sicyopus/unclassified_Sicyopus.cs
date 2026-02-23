using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Sicyopus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Sicyopus.unclassified_Sicyopus;

/// <summary>
/// Abstract class for unclassified Sicyopus (no rank).
/// NCBI TaxId: 2648965
/// </summary>
public abstract class unclassified_Sicyopus : Sicyopus, Iunclassified_Sicyopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sicyopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648965;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sicyopus";
}
