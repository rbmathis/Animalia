using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Contusus;

/// <summary>
/// Abstract class for Contusus (genus).
/// NCBI TaxId: 1680837
/// </summary>
public abstract class Contusus : Tetraodontidae, IContusus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Contusus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1680837;

    /// <inheritdoc />
    public virtual string GenusName => "Contusus";

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
