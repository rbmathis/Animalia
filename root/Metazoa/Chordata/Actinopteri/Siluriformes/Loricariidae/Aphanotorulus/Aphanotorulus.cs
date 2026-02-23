using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Aphanotorulus;

/// <summary>
/// Abstract class for Aphanotorulus (genus).
/// NCBI TaxId: 163987
/// </summary>
public abstract class Aphanotorulus : Loricariidae, IAphanotorulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aphanotorulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 163987;

    /// <inheritdoc />
    public virtual string GenusName => "Aphanotorulus";

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
