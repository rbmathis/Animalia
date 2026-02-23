using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Nemuroglanis;

/// <summary>
/// Abstract class for Nemuroglanis (genus).
/// NCBI TaxId: 2821908
/// </summary>
public abstract class Nemuroglanis : Heptapteridae, INemuroglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nemuroglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821908;

    /// <inheritdoc />
    public virtual string GenusName => "Nemuroglanis";

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
