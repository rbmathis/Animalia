using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Pycnocraspedum;

/// <summary>
/// Abstract class for Pycnocraspedum (genus).
/// NCBI TaxId: 2719940
/// </summary>
public abstract class Pycnocraspedum : Ophidiidae, IPycnocraspedum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pycnocraspedum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2719940;

    /// <inheritdoc />
    public virtual string GenusName => "Pycnocraspedum";

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
