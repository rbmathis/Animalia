using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Pycnoclavellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Pycnoclavellidae.Pycnoclavella;

/// <summary>
/// Abstract class for Pycnoclavella (genus).
/// NCBI TaxId: 286209
/// </summary>
public abstract class Pycnoclavella : Pycnoclavellidae, IPycnoclavella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pycnoclavella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 286209;

    /// <inheritdoc />
    public virtual string GenusName => "Pycnoclavella";

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
