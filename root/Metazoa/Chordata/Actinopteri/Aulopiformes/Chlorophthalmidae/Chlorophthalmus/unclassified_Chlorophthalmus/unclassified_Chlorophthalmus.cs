using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Chlorophthalmidae.Chlorophthalmus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Chlorophthalmidae.Chlorophthalmus.unclassified_Chlorophthalmus;

/// <summary>
/// Abstract class for unclassified Chlorophthalmus (no rank).
/// NCBI TaxId: 2630842
/// </summary>
public abstract class unclassified_Chlorophthalmus : Chlorophthalmus, Iunclassified_Chlorophthalmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chlorophthalmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630842;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chlorophthalmus";
}
