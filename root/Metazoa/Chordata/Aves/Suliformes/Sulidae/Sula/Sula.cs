using AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Sulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Sulidae.Sula;

/// <summary>
/// Abstract class for Sula (genus).
/// NCBI TaxId: 32641
/// </summary>
public abstract class Sula : Sulidae, ISula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 32641;

    /// <inheritdoc />
    public virtual string GenusName => "Sula";

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
