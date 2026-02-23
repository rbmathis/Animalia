using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Jenkinsia;

/// <summary>
/// Abstract class for Jenkinsia (genus).
/// NCBI TaxId: 221865
/// </summary>
public abstract class Jenkinsia : Clupeidae, IJenkinsia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Jenkinsia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 221865;

    /// <inheritdoc />
    public virtual string GenusName => "Jenkinsia";

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
