using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Auxis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Auxis.unclassified_Auxis;

/// <summary>
/// Abstract class for unclassified Auxis (no rank).
/// NCBI TaxId: 2629796
/// </summary>
public abstract class unclassified_Auxis : Auxis, Iunclassified_Auxis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Auxis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629796;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Auxis";
}
