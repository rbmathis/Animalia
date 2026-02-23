using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Notopteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Notopteridae.Notopterus;

/// <summary>
/// Abstract class for Notopterus (genus).
/// NCBI TaxId: 42651
/// </summary>
public abstract class Notopterus : Notopteridae, INotopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42651;

    /// <inheritdoc />
    public virtual string GenusName => "Notopterus";

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
