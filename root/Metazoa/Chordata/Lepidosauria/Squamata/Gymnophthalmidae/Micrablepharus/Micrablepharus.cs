using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Micrablepharus;

/// <summary>
/// Abstract class for Micrablepharus (genus).
/// NCBI TaxId: 174753
/// </summary>
public abstract class Micrablepharus : Gymnophthalmidae, IMicrablepharus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micrablepharus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 174753;

    /// <inheritdoc />
    public virtual string GenusName => "Micrablepharus";

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
