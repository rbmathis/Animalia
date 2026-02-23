using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae.Dissostichus;

/// <summary>
/// Abstract class for Dissostichus (genus).
/// NCBI TaxId: 36199
/// </summary>
public abstract class Dissostichus : Nototheniidae, IDissostichus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dissostichus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36199;

    /// <inheritdoc />
    public virtual string GenusName => "Dissostichus";

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
