using AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Alligatoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Alligatoridae.Paleosuchus;

/// <summary>
/// Abstract class for Paleosuchus (genus).
/// NCBI TaxId: 38657
/// </summary>
public abstract class Paleosuchus : Alligatoridae, IPaleosuchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paleosuchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 38657;

    /// <inheritdoc />
    public virtual string GenusName => "Paleosuchus";

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
