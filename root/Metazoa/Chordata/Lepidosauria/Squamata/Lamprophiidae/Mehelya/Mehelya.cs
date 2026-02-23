using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Mehelya;

/// <summary>
/// Abstract class for Mehelya (genus).
/// NCBI TaxId: 2259173
/// </summary>
public abstract class Mehelya : Lamprophiidae, IMehelya
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mehelya";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2259173;

    /// <inheritdoc />
    public virtual string GenusName => "Mehelya";

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
