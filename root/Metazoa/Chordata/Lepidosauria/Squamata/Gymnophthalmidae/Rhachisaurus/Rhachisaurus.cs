using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Rhachisaurus;

/// <summary>
/// Abstract class for Rhachisaurus (genus).
/// NCBI TaxId: 1333646
/// </summary>
public abstract class Rhachisaurus : Gymnophthalmidae, IRhachisaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhachisaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1333646;

    /// <inheritdoc />
    public virtual string GenusName => "Rhachisaurus";

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
