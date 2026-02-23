using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Glaridoglanis;

/// <summary>
/// Abstract class for Glaridoglanis (genus).
/// NCBI TaxId: 278782
/// </summary>
public abstract class Glaridoglanis : Sisoridae, IGlaridoglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glaridoglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 278782;

    /// <inheritdoc />
    public virtual string GenusName => "Glaridoglanis";

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
