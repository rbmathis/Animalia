using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Molidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Molidae.Mola;

/// <summary>
/// Abstract class for Mola (genus).
/// NCBI TaxId: 94236
/// </summary>
public abstract class Mola : Molidae, IMola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94236;

    /// <inheritdoc />
    public virtual string GenusName => "Mola";

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
