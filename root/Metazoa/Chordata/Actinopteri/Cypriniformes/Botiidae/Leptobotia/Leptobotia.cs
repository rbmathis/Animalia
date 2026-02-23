using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Botiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Botiidae.Leptobotia;

/// <summary>
/// Abstract class for Leptobotia (genus).
/// NCBI TaxId: 143402
/// </summary>
public abstract class Leptobotia : Botiidae, ILeptobotia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptobotia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143402;

    /// <inheritdoc />
    public virtual string GenusName => "Leptobotia";

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
