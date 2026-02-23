using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Phisalixella;

/// <summary>
/// Abstract class for Phisalixella (genus).
/// NCBI TaxId: 875663
/// </summary>
public abstract class Phisalixella : Lamprophiidae, IPhisalixella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phisalixella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 875663;

    /// <inheritdoc />
    public virtual string GenusName => "Phisalixella";

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
