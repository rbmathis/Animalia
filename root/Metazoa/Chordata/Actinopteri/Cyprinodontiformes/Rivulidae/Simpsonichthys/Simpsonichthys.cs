using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Simpsonichthys;

/// <summary>
/// Abstract class for Simpsonichthys (genus).
/// NCBI TaxId: 135317
/// </summary>
public abstract class Simpsonichthys : Rivulidae, ISimpsonichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Simpsonichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 135317;

    /// <inheritdoc />
    public virtual string GenusName => "Simpsonichthys";

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
