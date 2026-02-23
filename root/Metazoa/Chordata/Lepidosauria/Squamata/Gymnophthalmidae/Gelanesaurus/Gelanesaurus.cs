using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Gelanesaurus;

/// <summary>
/// Abstract class for Gelanesaurus (genus).
/// NCBI TaxId: 2025710
/// </summary>
public abstract class Gelanesaurus : Gymnophthalmidae, IGelanesaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gelanesaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2025710;

    /// <inheritdoc />
    public virtual string GenusName => "Gelanesaurus";

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
