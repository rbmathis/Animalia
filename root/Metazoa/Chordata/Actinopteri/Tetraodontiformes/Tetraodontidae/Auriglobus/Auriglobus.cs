using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Auriglobus;

/// <summary>
/// Abstract class for Auriglobus (genus).
/// NCBI TaxId: 862798
/// </summary>
public abstract class Auriglobus : Tetraodontidae, IAuriglobus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Auriglobus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 862798;

    /// <inheritdoc />
    public virtual string GenusName => "Auriglobus";

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
