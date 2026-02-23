using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae.Pariosternarchus;

/// <summary>
/// Abstract class for Pariosternarchus (genus).
/// NCBI TaxId: 2175715
/// </summary>
public abstract class Pariosternarchus : Apteronotidae, IPariosternarchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pariosternarchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2175715;

    /// <inheritdoc />
    public virtual string GenusName => "Pariosternarchus";

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
