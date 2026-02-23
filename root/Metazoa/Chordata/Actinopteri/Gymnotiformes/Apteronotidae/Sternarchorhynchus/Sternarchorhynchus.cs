using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae.Sternarchorhynchus;

/// <summary>
/// Abstract class for Sternarchorhynchus (genus).
/// NCBI TaxId: 1740101
/// </summary>
public abstract class Sternarchorhynchus : Apteronotidae, ISternarchorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sternarchorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1740101;

    /// <inheritdoc />
    public virtual string GenusName => "Sternarchorhynchus";

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
