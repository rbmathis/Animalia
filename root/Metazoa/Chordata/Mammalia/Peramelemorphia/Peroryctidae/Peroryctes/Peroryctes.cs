using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Peramelemorphia.Peroryctidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Peramelemorphia.Peroryctidae.Peroryctes;

/// <summary>
/// Abstract class for Peroryctes (genus).
/// NCBI TaxId: 65627
/// </summary>
public abstract class Peroryctes : Peroryctidae, IPeroryctes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Peroryctes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 65627;

    /// <inheritdoc />
    public virtual string GenusName => "Peroryctes";

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
