using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Atlantirivulus;

/// <summary>
/// Abstract class for Atlantirivulus (genus).
/// NCBI TaxId: 1254595
/// </summary>
public abstract class Atlantirivulus : Rivulidae, IAtlantirivulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atlantirivulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1254595;

    /// <inheritdoc />
    public virtual string GenusName => "Atlantirivulus";

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
