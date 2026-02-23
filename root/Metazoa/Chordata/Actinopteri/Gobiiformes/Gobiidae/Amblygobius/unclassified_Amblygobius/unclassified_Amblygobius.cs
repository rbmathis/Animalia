using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Amblygobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Amblygobius.unclassified_Amblygobius;

/// <summary>
/// Abstract class for unclassified Amblygobius (no rank).
/// NCBI TaxId: 2621496
/// </summary>
public abstract class unclassified_Amblygobius : Amblygobius, Iunclassified_Amblygobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Amblygobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621496;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Amblygobius";
}
