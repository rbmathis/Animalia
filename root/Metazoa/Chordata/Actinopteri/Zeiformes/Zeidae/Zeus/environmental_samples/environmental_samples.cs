using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Zeidae.Zeus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Zeidae.Zeus.environmental_samples;

/// <summary>
/// Abstract class for environmental samples (no rank).
/// NCBI TaxId: 1814162
/// </summary>
public abstract class environmental_samples : Zeus, Ienvironmental_samples
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "environmental samples";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1814162;

    /// <inheritdoc />
    public virtual string Description => "Taxon: environmental_samples";
}
