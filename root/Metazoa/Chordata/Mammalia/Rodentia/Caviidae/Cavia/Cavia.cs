using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Caviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Caviidae.Cavia;

/// <summary>
/// Abstract class for Cavia (genus).
/// NCBI TaxId: 10140
/// </summary>
public abstract class Cavia : Caviidae, ICavia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cavia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10140;

    /// <inheritdoc />
    public virtual string GenusName => "Cavia";

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
