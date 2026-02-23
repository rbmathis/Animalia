using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Creteuchiloglanis;

/// <summary>
/// Abstract class for Creteuchiloglanis (genus).
/// NCBI TaxId: 1128654
/// </summary>
public abstract class Creteuchiloglanis : Sisoridae, ICreteuchiloglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Creteuchiloglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1128654;

    /// <inheritdoc />
    public virtual string GenusName => "Creteuchiloglanis";

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
