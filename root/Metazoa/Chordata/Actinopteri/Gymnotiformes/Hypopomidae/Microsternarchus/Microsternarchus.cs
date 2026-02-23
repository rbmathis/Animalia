using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Hypopomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Hypopomidae.Microsternarchus;

/// <summary>
/// Abstract class for Microsternarchus (genus).
/// NCBI TaxId: 36687
/// </summary>
public abstract class Microsternarchus : Hypopomidae, IMicrosternarchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microsternarchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36687;

    /// <inheritdoc />
    public virtual string GenusName => "Microsternarchus";

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
