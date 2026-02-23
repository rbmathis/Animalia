using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae.Lagusia;

/// <summary>
/// Abstract class for Lagusia (genus).
/// NCBI TaxId: 3096650
/// </summary>
public abstract class Lagusia : Terapontidae, ILagusia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lagusia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3096650;

    /// <inheritdoc />
    public virtual string GenusName => "Lagusia";

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
