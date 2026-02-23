using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae.Halidesmus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae.Halidesmus.unclassified_Halidesmus;

/// <summary>
/// Abstract class for unclassified Halidesmus (no rank).
/// NCBI TaxId: 2990304
/// </summary>
public abstract class unclassified_Halidesmus : Halidesmus, Iunclassified_Halidesmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Halidesmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2990304;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Halidesmus";
}
