using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Euchiloglanis;

/// <summary>
/// Abstract class for Euchiloglanis (genus).
/// NCBI TaxId: 175775
/// </summary>
public abstract class Euchiloglanis : Sisoridae, IEuchiloglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euchiloglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 175775;

    /// <inheritdoc />
    public virtual string GenusName => "Euchiloglanis";

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
