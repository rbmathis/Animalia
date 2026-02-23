using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Labeoninae_incertae_sedis.Sinilabeo;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Labeoninae_incertae_sedis.Sinilabeo.unclassified_Sinilabeo;

/// <summary>
/// Abstract class for unclassified Sinilabeo (no rank).
/// NCBI TaxId: 2622856
/// </summary>
public abstract class unclassified_Sinilabeo : Sinilabeo, Iunclassified_Sinilabeo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sinilabeo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622856;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sinilabeo";
}
