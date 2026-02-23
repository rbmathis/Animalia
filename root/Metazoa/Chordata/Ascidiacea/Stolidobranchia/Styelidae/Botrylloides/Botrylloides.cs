using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Styelidae.Botrylloides;

/// <summary>
/// Abstract class for Botrylloides (genus).
/// NCBI TaxId: 62806
/// </summary>
public abstract class Botrylloides : Styelidae, IBotrylloides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Botrylloides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62806;

    /// <inheritdoc />
    public virtual string GenusName => "Botrylloides";

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
