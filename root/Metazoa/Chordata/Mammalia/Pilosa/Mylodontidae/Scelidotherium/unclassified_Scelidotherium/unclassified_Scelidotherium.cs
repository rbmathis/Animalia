using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Mylodontidae.Scelidotherium;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Mylodontidae.Scelidotherium.unclassified_Scelidotherium;

/// <summary>
/// Abstract class for unclassified Scelidotherium (no rank).
/// NCBI TaxId: 2626770
/// </summary>
public abstract class unclassified_Scelidotherium : Scelidotherium, Iunclassified_Scelidotherium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scelidotherium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626770;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scelidotherium";
}
