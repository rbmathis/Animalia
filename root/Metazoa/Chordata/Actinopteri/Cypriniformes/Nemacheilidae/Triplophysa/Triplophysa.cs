using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Triplophysa;

/// <summary>
/// Abstract class for Triplophysa (genus).
/// NCBI TaxId: 341122
/// </summary>
public abstract class Triplophysa : Nemacheilidae, ITriplophysa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Triplophysa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 341122;

    /// <inheritdoc />
    public virtual string GenusName => "Triplophysa";

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
