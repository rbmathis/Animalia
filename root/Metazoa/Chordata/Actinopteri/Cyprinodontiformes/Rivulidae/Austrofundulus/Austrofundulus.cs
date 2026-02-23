using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Austrofundulus;

/// <summary>
/// Abstract class for Austrofundulus (genus).
/// NCBI TaxId: 52669
/// </summary>
public abstract class Austrofundulus : Rivulidae, IAustrofundulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Austrofundulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52669;

    /// <inheritdoc />
    public virtual string GenusName => "Austrofundulus";

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
