using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae.Teramulus;

/// <summary>
/// Abstract class for Teramulus (genus).
/// NCBI TaxId: 238710
/// </summary>
public abstract class Teramulus : Atherinidae, ITeramulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Teramulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238710;

    /// <inheritdoc />
    public virtual string GenusName => "Teramulus";

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
