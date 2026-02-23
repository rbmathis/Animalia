using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Sisor;

/// <summary>
/// Abstract class for Sisor (genus).
/// NCBI TaxId: 385309
/// </summary>
public abstract class Sisor : Sisoridae, ISisor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sisor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 385309;

    /// <inheritdoc />
    public virtual string GenusName => "Sisor";

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
