using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Plectropomus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Plectropomus.unclassified_Plectropomus;

/// <summary>
/// Abstract class for unclassified Plectropomus (no rank).
/// NCBI TaxId: 2633646
/// </summary>
public abstract class unclassified_Plectropomus : Plectropomus, Iunclassified_Plectropomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Plectropomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633646;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Plectropomus";
}
