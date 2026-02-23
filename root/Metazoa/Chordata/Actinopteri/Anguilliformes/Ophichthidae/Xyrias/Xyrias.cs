using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Xyrias;

/// <summary>
/// Abstract class for Xyrias (genus).
/// NCBI TaxId: 189511
/// </summary>
public abstract class Xyrias : Ophichthidae, IXyrias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xyrias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 189511;

    /// <inheritdoc />
    public virtual string GenusName => "Xyrias";

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
