using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Atropus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Atropus.unclassified_Atropus;

/// <summary>
/// Abstract class for unclassified Atropus (no rank).
/// NCBI TaxId: 3142570
/// </summary>
public abstract class unclassified_Atropus : Atropus, Iunclassified_Atropus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Atropus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3142570;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Atropus";
}
