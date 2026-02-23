using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Solea;

/// <summary>
/// Abstract class for Solea (genus).
/// NCBI TaxId: 28828
/// </summary>
public abstract class Solea : Soleidae, ISolea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Solea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28828;

    /// <inheritdoc />
    public virtual string GenusName => "Solea";

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
