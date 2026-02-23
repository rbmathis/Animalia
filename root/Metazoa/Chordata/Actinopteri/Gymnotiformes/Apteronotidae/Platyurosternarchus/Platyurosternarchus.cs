using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae.Platyurosternarchus;

/// <summary>
/// Abstract class for Platyurosternarchus (genus).
/// NCBI TaxId: 1740096
/// </summary>
public abstract class Platyurosternarchus : Apteronotidae, IPlatyurosternarchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platyurosternarchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1740096;

    /// <inheritdoc />
    public virtual string GenusName => "Platyurosternarchus";

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
