using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Parabramis;

/// <summary>
/// Abstract class for Parabramis (genus).
/// NCBI TaxId: 75357
/// </summary>
public abstract class Parabramis : Xenocyprididae, IParabramis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parabramis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75357;

    /// <inheritdoc />
    public virtual string GenusName => "Parabramis";

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
