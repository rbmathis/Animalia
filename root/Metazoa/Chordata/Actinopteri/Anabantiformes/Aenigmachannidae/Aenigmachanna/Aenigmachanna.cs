using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Aenigmachannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Aenigmachannidae.Aenigmachanna;

/// <summary>
/// Abstract class for Aenigmachanna (genus).
/// NCBI TaxId: 2586743
/// </summary>
public abstract class Aenigmachanna : Aenigmachannidae, IAenigmachanna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aenigmachanna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2586743;

    /// <inheritdoc />
    public virtual string GenusName => "Aenigmachanna";

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
