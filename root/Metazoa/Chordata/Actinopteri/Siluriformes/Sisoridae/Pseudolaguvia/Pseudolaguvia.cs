using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Pseudolaguvia;

/// <summary>
/// Abstract class for Pseudolaguvia (genus).
/// NCBI TaxId: 385286
/// </summary>
public abstract class Pseudolaguvia : Sisoridae, IPseudolaguvia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudolaguvia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 385286;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudolaguvia";

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
