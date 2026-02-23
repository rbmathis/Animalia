using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Argyrosomus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Argyrosomus.unclassified_Argyrosomus;

/// <summary>
/// Abstract class for unclassified Argyrosomus (no rank).
/// NCBI TaxId: 3445694
/// </summary>
public abstract class unclassified_Argyrosomus : Argyrosomus, Iunclassified_Argyrosomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Argyrosomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3445694;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Argyrosomus";
}
