using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brevicipitidae.Callulina;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brevicipitidae.Callulina.unclassified_Callulina;

/// <summary>
/// Abstract class for unclassified Callulina (no rank).
/// NCBI TaxId: 2645102
/// </summary>
public abstract class unclassified_Callulina : Callulina, Iunclassified_Callulina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Callulina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645102;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Callulina";
}
