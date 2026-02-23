using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Serrasalmus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Serrasalmus.unclassified_Serrasalmus;

/// <summary>
/// Abstract class for unclassified Serrasalmus (no rank).
/// NCBI TaxId: 2632652
/// </summary>
public abstract class unclassified_Serrasalmus : Serrasalmus, Iunclassified_Serrasalmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Serrasalmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632652;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Serrasalmus";
}
