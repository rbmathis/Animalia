using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Pareuchiloglanis;

/// <summary>
/// Abstract class for Pareuchiloglanis (genus).
/// NCBI TaxId: 221671
/// </summary>
public abstract class Pareuchiloglanis : Sisoridae, IPareuchiloglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pareuchiloglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 221671;

    /// <inheritdoc />
    public virtual string GenusName => "Pareuchiloglanis";

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
