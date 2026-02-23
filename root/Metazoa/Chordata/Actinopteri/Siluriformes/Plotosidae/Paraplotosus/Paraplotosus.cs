using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae.Paraplotosus;

/// <summary>
/// Abstract class for Paraplotosus (genus).
/// NCBI TaxId: 1417751
/// </summary>
public abstract class Paraplotosus : Plotosidae, IParaplotosus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paraplotosus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1417751;

    /// <inheritdoc />
    public virtual string GenusName => "Paraplotosus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
