using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Atrosalarias;

/// <summary>
/// Abstract class for Atrosalarias (genus).
/// NCBI TaxId: 879705
/// </summary>
public abstract class Atrosalarias : Blenniidae, IAtrosalarias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atrosalarias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 879705;

    /// <inheritdoc />
    public virtual string GenusName => "Atrosalarias";

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
