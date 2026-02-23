using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Macrochirichthys;

/// <summary>
/// Abstract class for Macrochirichthys (genus).
/// NCBI TaxId: 516033
/// </summary>
public abstract class Macrochirichthys : Xenocyprididae, IMacrochirichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macrochirichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 516033;

    /// <inheritdoc />
    public virtual string GenusName => "Macrochirichthys";

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
