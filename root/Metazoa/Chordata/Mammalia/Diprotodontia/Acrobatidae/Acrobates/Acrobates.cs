using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Acrobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Acrobatidae.Acrobates;

/// <summary>
/// Abstract class for Acrobates (genus).
/// NCBI TaxId: 190719
/// </summary>
public abstract class Acrobates : Acrobatidae, IAcrobates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acrobates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 190719;

    /// <inheritdoc />
    public virtual string GenusName => "Acrobates";

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
