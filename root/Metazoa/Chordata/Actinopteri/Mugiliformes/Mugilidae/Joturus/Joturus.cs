using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Joturus;

/// <summary>
/// Abstract class for Joturus (genus).
/// NCBI TaxId: 1040950
/// </summary>
public abstract class Joturus : Mugilidae, IJoturus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Joturus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1040950;

    /// <inheritdoc />
    public virtual string GenusName => "Joturus";

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
