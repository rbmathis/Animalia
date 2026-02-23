using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Clarias;

/// <summary>
/// Abstract class for Clarias (genus).
/// NCBI TaxId: 13012
/// </summary>
public abstract class Clarias : Clariidae, IClarias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clarias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13012;

    /// <inheritdoc />
    public virtual string GenusName => "Clarias";

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
