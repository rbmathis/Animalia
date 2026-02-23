using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Sternopygidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Sternopygidae.Japigny;

/// <summary>
/// Abstract class for Japigny (genus).
/// NCBI TaxId: 2595000
/// </summary>
public abstract class Japigny : Sternopygidae, IJapigny
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Japigny";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2595000;

    /// <inheritdoc />
    public virtual string GenusName => "Japigny";

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
