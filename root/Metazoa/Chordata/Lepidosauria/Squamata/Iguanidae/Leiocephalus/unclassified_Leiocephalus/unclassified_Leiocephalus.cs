using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Leiocephalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Leiocephalus.unclassified_Leiocephalus;

/// <summary>
/// Abstract class for unclassified Leiocephalus (no rank).
/// NCBI TaxId: 2628897
/// </summary>
public abstract class unclassified_Leiocephalus : Leiocephalus, Iunclassified_Leiocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leiocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628897;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leiocephalus";
}
