using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Pseudexostoma;

/// <summary>
/// Abstract class for Pseudexostoma (genus).
/// NCBI TaxId: 175783
/// </summary>
public abstract class Pseudexostoma : Sisoridae, IPseudexostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudexostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 175783;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudexostoma";

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
