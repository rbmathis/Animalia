using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Anotosaura;

/// <summary>
/// Abstract class for Anotosaura (genus).
/// NCBI TaxId: 174735
/// </summary>
public abstract class Anotosaura : Gymnophthalmidae, IAnotosaura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anotosaura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 174735;

    /// <inheritdoc />
    public virtual string GenusName => "Anotosaura";

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
