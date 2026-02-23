using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Archosargus;

/// <summary>
/// Abstract class for Archosargus (genus).
/// NCBI TaxId: 119681
/// </summary>
public abstract class Archosargus : Sparidae, IArchosargus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Archosargus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 119681;

    /// <inheritdoc />
    public virtual string GenusName => "Archosargus";

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
