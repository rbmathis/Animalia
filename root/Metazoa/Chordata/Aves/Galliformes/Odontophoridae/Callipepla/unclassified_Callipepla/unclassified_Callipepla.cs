using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae.Callipepla;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae.Callipepla.unclassified_Callipepla;

/// <summary>
/// Abstract class for unclassified Callipepla (no rank).
/// NCBI TaxId: 2878737
/// </summary>
public abstract class unclassified_Callipepla : Callipepla, Iunclassified_Callipepla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Callipepla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2878737;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Callipepla";
}
