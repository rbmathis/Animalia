using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Chimarrichthys;

/// <summary>
/// Abstract class for Chimarrichthys (genus).
/// NCBI TaxId: 2202368
/// </summary>
public abstract class Chimarrichthys : Sisoridae, IChimarrichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chimarrichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2202368;

    /// <inheritdoc />
    public virtual string GenusName => "Chimarrichthys";

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
