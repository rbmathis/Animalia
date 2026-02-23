using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Echeneidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Echeneidae.Phtheirichthys;

/// <summary>
/// Abstract class for Phtheirichthys (genus).
/// NCBI TaxId: 641293
/// </summary>
public abstract class Phtheirichthys : Echeneidae, IPhtheirichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phtheirichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 641293;

    /// <inheritdoc />
    public virtual string GenusName => "Phtheirichthys";

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
