using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Sparodon;

/// <summary>
/// Abstract class for Sparodon (genus).
/// NCBI TaxId: 119747
/// </summary>
public abstract class Sparodon : Sparidae, ISparodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sparodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 119747;

    /// <inheritdoc />
    public virtual string GenusName => "Sparodon";

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
