using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Maratecoara;

/// <summary>
/// Abstract class for Maratecoara (genus).
/// NCBI TaxId: 61821
/// </summary>
public abstract class Maratecoara : Rivulidae, IMaratecoara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Maratecoara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61821;

    /// <inheritdoc />
    public virtual string GenusName => "Maratecoara";

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
