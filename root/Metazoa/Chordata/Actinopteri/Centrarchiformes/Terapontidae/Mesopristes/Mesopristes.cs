using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae.Mesopristes;

/// <summary>
/// Abstract class for Mesopristes (genus).
/// NCBI TaxId: 1100887
/// </summary>
public abstract class Mesopristes : Terapontidae, IMesopristes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mesopristes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1100887;

    /// <inheritdoc />
    public virtual string GenusName => "Mesopristes";

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
