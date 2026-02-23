using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.unclassified_Phasianidae;

/// <summary>
/// Abstract class for unclassified Phasianidae (no rank).
/// NCBI TaxId: 2922367
/// </summary>
public abstract class unclassified_Phasianidae : Phasianidae, Iunclassified_Phasianidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phasianidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2922367;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phasianidae";
}
