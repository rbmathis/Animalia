using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Tetragonopterus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Tetragonopterus.unclassified_Tetragonopterus;

/// <summary>
/// Abstract class for unclassified Tetragonopterus (no rank).
/// NCBI TaxId: 2634606
/// </summary>
public abstract class unclassified_Tetragonopterus : Tetragonopterus, Iunclassified_Tetragonopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tetragonopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634606;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tetragonopterus";
}
