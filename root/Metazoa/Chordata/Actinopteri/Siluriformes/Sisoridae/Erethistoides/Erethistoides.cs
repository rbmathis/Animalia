using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Erethistoides;

/// <summary>
/// Abstract class for Erethistoides (genus).
/// NCBI TaxId: 385290
/// </summary>
public abstract class Erethistoides : Sisoridae, IErethistoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Erethistoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 385290;

    /// <inheritdoc />
    public virtual string GenusName => "Erethistoides";

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
