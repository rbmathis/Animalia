using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Lenothrix;

/// <summary>
/// Abstract class for Lenothrix (genus).
/// NCBI TaxId: 2021986
/// </summary>
public abstract class Lenothrix : Muridae, ILenothrix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lenothrix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2021986;

    /// <inheritdoc />
    public virtual string GenusName => "Lenothrix";

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
