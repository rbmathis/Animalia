using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Sternopygidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Sternopygidae.Eigenmannia;

/// <summary>
/// Abstract class for Eigenmannia (genus).
/// NCBI TaxId: 36703
/// </summary>
public abstract class Eigenmannia : Sternopygidae, IEigenmannia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eigenmannia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36703;

    /// <inheritdoc />
    public virtual string GenusName => "Eigenmannia";

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
