using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Procellosaurinus;

/// <summary>
/// Abstract class for Procellosaurinus (genus).
/// NCBI TaxId: 174760
/// </summary>
public abstract class Procellosaurinus : Gymnophthalmidae, IProcellosaurinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Procellosaurinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 174760;

    /// <inheritdoc />
    public virtual string GenusName => "Procellosaurinus";

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
