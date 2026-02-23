using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Margariscus;

/// <summary>
/// Abstract class for Margariscus (genus).
/// NCBI TaxId: 67546
/// </summary>
public abstract class Margariscus : Leuciscidae, IMargariscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Margariscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 67546;

    /// <inheritdoc />
    public virtual string GenusName => "Margariscus";

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
