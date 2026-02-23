using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Balistidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Balistidae.Balistoides;

/// <summary>
/// Abstract class for Balistoides (genus).
/// NCBI TaxId: 303688
/// </summary>
public abstract class Balistoides : Balistidae, IBalistoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Balistoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303688;

    /// <inheritdoc />
    public virtual string GenusName => "Balistoides";

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
