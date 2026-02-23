using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Melanorivulus;

/// <summary>
/// Abstract class for Melanorivulus (genus).
/// NCBI TaxId: 1254597
/// </summary>
public abstract class Melanorivulus : Rivulidae, IMelanorivulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melanorivulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1254597;

    /// <inheritdoc />
    public virtual string GenusName => "Melanorivulus";

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
