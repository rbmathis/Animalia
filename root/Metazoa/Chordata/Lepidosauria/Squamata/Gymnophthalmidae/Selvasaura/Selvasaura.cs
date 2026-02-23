using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Selvasaura;

/// <summary>
/// Abstract class for Selvasaura (genus).
/// NCBI TaxId: 2293891
/// </summary>
public abstract class Selvasaura : Gymnophthalmidae, ISelvasaura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Selvasaura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2293891;

    /// <inheritdoc />
    public virtual string GenusName => "Selvasaura";

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
