using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Petrotyx;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Petrotyx.unclassified_Petrotyx;

/// <summary>
/// Abstract class for unclassified Petrotyx (no rank).
/// NCBI TaxId: 2677765
/// </summary>
public abstract class unclassified_Petrotyx : Petrotyx, Iunclassified_Petrotyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Petrotyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677765;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Petrotyx";
}
