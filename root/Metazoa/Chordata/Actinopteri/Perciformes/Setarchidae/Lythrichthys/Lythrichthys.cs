using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Setarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Setarchidae.Lythrichthys;

/// <summary>
/// Abstract class for Lythrichthys (genus).
/// NCBI TaxId: 2841738
/// </summary>
public abstract class Lythrichthys : Setarchidae, ILythrichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lythrichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2841738;

    /// <inheritdoc />
    public virtual string GenusName => "Lythrichthys";

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
