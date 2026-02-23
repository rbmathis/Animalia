using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Xeniamia;

/// <summary>
/// Abstract class for Xeniamia (genus).
/// NCBI TaxId: 2608479
/// </summary>
public abstract class Xeniamia : Apogonidae, IXeniamia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xeniamia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2608479;

    /// <inheritdoc />
    public virtual string GenusName => "Xeniamia";

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
