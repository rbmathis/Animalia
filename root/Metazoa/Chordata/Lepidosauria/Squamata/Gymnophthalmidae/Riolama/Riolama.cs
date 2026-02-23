using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Riolama;

/// <summary>
/// Abstract class for Riolama (genus).
/// NCBI TaxId: 174764
/// </summary>
public abstract class Riolama : Gymnophthalmidae, IRiolama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Riolama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 174764;

    /// <inheritdoc />
    public virtual string GenusName => "Riolama";

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
