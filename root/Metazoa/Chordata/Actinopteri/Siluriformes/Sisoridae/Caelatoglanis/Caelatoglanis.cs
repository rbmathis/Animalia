using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Caelatoglanis;

/// <summary>
/// Abstract class for Caelatoglanis (genus).
/// NCBI TaxId: 385274
/// </summary>
public abstract class Caelatoglanis : Sisoridae, ICaelatoglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caelatoglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 385274;

    /// <inheritdoc />
    public virtual string GenusName => "Caelatoglanis";

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
