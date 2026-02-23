using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Pyxichromis;

/// <summary>
/// Abstract class for Pyxichromis (genus).
/// NCBI TaxId: 2766850
/// </summary>
public abstract class Pyxichromis : Cichlidae, IPyxichromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pyxichromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2766850;

    /// <inheritdoc />
    public virtual string GenusName => "Pyxichromis";

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
