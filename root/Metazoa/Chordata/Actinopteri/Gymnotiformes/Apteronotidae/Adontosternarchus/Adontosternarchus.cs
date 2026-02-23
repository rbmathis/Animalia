using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae.Adontosternarchus;

/// <summary>
/// Abstract class for Adontosternarchus (genus).
/// NCBI TaxId: 36683
/// </summary>
public abstract class Adontosternarchus : Apteronotidae, IAdontosternarchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Adontosternarchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36683;

    /// <inheritdoc />
    public virtual string GenusName => "Adontosternarchus";

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
