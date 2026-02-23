using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Coranthus;

/// <summary>
/// Abstract class for Coranthus (genus).
/// NCBI TaxId: 1431506
/// </summary>
public abstract class Coranthus : Apogonidae, ICoranthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coranthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1431506;

    /// <inheritdoc />
    public virtual string GenusName => "Coranthus";

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
