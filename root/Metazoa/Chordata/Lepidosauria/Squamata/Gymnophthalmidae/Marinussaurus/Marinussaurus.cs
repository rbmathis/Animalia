using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Marinussaurus;

/// <summary>
/// Abstract class for Marinussaurus (genus).
/// NCBI TaxId: 1049032
/// </summary>
public abstract class Marinussaurus : Gymnophthalmidae, IMarinussaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Marinussaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1049032;

    /// <inheritdoc />
    public virtual string GenusName => "Marinussaurus";

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
