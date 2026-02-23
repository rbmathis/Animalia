using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Paramormyrops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Paramormyrops.unclassified_Paramormyrops;

/// <summary>
/// Abstract class for unclassified Paramormyrops (no rank).
/// NCBI TaxId: 2630341
/// </summary>
public abstract class unclassified_Paramormyrops : Paramormyrops, Iunclassified_Paramormyrops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paramormyrops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630341;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paramormyrops";
}
