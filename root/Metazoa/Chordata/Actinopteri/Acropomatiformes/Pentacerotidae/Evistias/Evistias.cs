using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Pentacerotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Pentacerotidae.Evistias;

/// <summary>
/// Abstract class for Evistias (genus).
/// NCBI TaxId: 1043191
/// </summary>
public abstract class Evistias : Pentacerotidae, IEvistias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Evistias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1043191;

    /// <inheritdoc />
    public virtual string GenusName => "Evistias";

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
