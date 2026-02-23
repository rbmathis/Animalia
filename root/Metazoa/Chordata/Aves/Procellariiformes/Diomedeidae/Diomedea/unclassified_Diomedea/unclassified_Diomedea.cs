using AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Diomedeidae.Diomedea;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Diomedeidae.Diomedea.unclassified_Diomedea;

/// <summary>
/// Abstract class for unclassified Diomedea (no rank).
/// NCBI TaxId: 2630897
/// </summary>
public abstract class unclassified_Diomedea : Diomedea, Iunclassified_Diomedea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Diomedea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630897;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Diomedea";
}
