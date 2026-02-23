using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Neofundulus;

/// <summary>
/// Abstract class for Neofundulus (genus).
/// NCBI TaxId: 61826
/// </summary>
public abstract class Neofundulus : Rivulidae, INeofundulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neofundulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61826;

    /// <inheritdoc />
    public virtual string GenusName => "Neofundulus";

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
