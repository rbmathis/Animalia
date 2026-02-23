using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Congosorex;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Congosorex.unclassified_Congosorex;

/// <summary>
/// Abstract class for unclassified Congosorex (no rank).
/// NCBI TaxId: 2643255
/// </summary>
public abstract class unclassified_Congosorex : Congosorex, Iunclassified_Congosorex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Congosorex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643255;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Congosorex";
}
