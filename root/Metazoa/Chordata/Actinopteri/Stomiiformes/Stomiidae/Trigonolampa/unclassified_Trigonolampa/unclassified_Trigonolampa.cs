using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Trigonolampa;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Trigonolampa.unclassified_Trigonolampa;

/// <summary>
/// Abstract class for unclassified Trigonolampa (no rank).
/// NCBI TaxId: 2980741
/// </summary>
public abstract class unclassified_Trigonolampa : Trigonolampa, Iunclassified_Trigonolampa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trigonolampa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2980741;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trigonolampa";
}
