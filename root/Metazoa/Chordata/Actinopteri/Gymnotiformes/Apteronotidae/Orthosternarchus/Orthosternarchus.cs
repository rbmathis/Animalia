using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae.Orthosternarchus;

/// <summary>
/// Abstract class for Orthosternarchus (genus).
/// NCBI TaxId: 36681
/// </summary>
public abstract class Orthosternarchus : Apteronotidae, IOrthosternarchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Orthosternarchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36681;

    /// <inheritdoc />
    public virtual string GenusName => "Orthosternarchus";

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
