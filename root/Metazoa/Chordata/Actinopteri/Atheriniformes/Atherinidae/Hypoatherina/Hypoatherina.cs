using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae.Hypoatherina;

/// <summary>
/// Abstract class for Hypoatherina (genus).
/// NCBI TaxId: 123717
/// </summary>
public abstract class Hypoatherina : Atherinidae, IHypoatherina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypoatherina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 123717;

    /// <inheritdoc />
    public virtual string GenusName => "Hypoatherina";

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
