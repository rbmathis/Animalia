using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae.Crenuchus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae.Crenuchus.unclassified_Crenuchus;

/// <summary>
/// Abstract class for unclassified Crenuchus (no rank).
/// NCBI TaxId: 2642637
/// </summary>
public abstract class unclassified_Crenuchus : Crenuchus, Iunclassified_Crenuchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Crenuchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642637;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Crenuchus";
}
