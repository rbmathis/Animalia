using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae.Tenebrosternarchus;

/// <summary>
/// Abstract class for Tenebrosternarchus (genus).
/// NCBI TaxId: 2936481
/// </summary>
public abstract class Tenebrosternarchus : Apteronotidae, ITenebrosternarchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tenebrosternarchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2936481;

    /// <inheritdoc />
    public virtual string GenusName => "Tenebrosternarchus";

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
