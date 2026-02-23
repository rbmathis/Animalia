using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Orthonopias;

/// <summary>
/// Abstract class for Orthonopias (genus).
/// NCBI TaxId: 305511
/// </summary>
public abstract class Orthonopias : Cottidae, IOrthonopias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Orthonopias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 305511;

    /// <inheritdoc />
    public virtual string GenusName => "Orthonopias";

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
