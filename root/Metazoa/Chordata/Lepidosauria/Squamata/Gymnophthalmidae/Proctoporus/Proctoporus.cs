using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Proctoporus;

/// <summary>
/// Abstract class for Proctoporus (genus).
/// NCBI TaxId: 174761
/// </summary>
public abstract class Proctoporus : Gymnophthalmidae, IProctoporus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Proctoporus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 174761;

    /// <inheritdoc />
    public virtual string GenusName => "Proctoporus";

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
