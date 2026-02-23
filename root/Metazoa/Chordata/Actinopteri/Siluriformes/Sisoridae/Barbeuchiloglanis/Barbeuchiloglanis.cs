using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Barbeuchiloglanis;

/// <summary>
/// Abstract class for Barbeuchiloglanis (genus).
/// NCBI TaxId: 3363389
/// </summary>
public abstract class Barbeuchiloglanis : Sisoridae, IBarbeuchiloglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Barbeuchiloglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363389;

    /// <inheritdoc />
    public virtual string GenusName => "Barbeuchiloglanis";

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
