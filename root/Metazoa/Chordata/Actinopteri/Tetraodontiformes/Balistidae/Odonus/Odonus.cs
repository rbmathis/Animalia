using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Balistidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Balistidae.Odonus;

/// <summary>
/// Abstract class for Odonus (genus).
/// NCBI TaxId: 392901
/// </summary>
public abstract class Odonus : Balistidae, IOdonus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Odonus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 392901;

    /// <inheritdoc />
    public virtual string GenusName => "Odonus";

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
