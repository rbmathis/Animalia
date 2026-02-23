using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Aztecula;

/// <summary>
/// Abstract class for Aztecula (genus).
/// NCBI TaxId: 479021
/// </summary>
public abstract class Aztecula : Leuciscidae, IAztecula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aztecula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 479021;

    /// <inheritdoc />
    public virtual string GenusName => "Aztecula";

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
