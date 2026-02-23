using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Austroglanididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Austroglanididae.Austroglanis;

/// <summary>
/// Abstract class for Austroglanis (genus).
/// NCBI TaxId: 2582928
/// </summary>
public abstract class Austroglanis : Austroglanididae, IAustroglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Austroglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2582928;

    /// <inheritdoc />
    public virtual string GenusName => "Austroglanis";

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
