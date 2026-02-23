using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Botiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Botiidae.Parabotia;

/// <summary>
/// Abstract class for Parabotia (genus).
/// NCBI TaxId: 143404
/// </summary>
public abstract class Parabotia : Botiidae, IParabotia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parabotia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143404;

    /// <inheritdoc />
    public virtual string GenusName => "Parabotia";

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
