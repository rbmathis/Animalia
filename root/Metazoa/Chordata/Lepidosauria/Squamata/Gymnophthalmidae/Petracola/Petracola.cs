using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Petracola;

/// <summary>
/// Abstract class for Petracola (genus).
/// NCBI TaxId: 1333722
/// </summary>
public abstract class Petracola : Gymnophthalmidae, IPetracola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Petracola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1333722;

    /// <inheritdoc />
    public virtual string GenusName => "Petracola";

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
