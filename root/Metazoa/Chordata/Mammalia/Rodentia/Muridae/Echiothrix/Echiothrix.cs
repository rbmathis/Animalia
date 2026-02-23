using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Echiothrix;

/// <summary>
/// Abstract class for Echiothrix (genus).
/// NCBI TaxId: 1638929
/// </summary>
public abstract class Echiothrix : Muridae, IEchiothrix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Echiothrix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1638929;

    /// <inheritdoc />
    public virtual string GenusName => "Echiothrix";

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
