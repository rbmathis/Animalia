using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Parachiloglanis;

/// <summary>
/// Abstract class for Parachiloglanis (genus).
/// NCBI TaxId: 2301578
/// </summary>
public abstract class Parachiloglanis : Sisoridae, IParachiloglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parachiloglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2301578;

    /// <inheritdoc />
    public virtual string GenusName => "Parachiloglanis";

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
