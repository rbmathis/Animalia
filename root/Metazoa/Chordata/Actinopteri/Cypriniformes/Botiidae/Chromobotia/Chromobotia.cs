using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Botiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Botiidae.Chromobotia;

/// <summary>
/// Abstract class for Chromobotia (genus).
/// NCBI TaxId: 322130
/// </summary>
public abstract class Chromobotia : Botiidae, IChromobotia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chromobotia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 322130;

    /// <inheritdoc />
    public virtual string GenusName => "Chromobotia";

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
