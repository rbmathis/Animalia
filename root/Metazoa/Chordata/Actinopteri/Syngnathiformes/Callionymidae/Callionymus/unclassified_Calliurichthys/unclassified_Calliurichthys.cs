using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae.Callionymus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae.Callionymus.unclassified_Calliurichthys;

/// <summary>
/// Abstract class for unclassified Calliurichthys (no rank).
/// NCBI TaxId: 2918731
/// </summary>
public abstract class unclassified_Calliurichthys : Callionymus, Iunclassified_Calliurichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Calliurichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2918731;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Calliurichthys";
}
