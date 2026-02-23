using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Abeillia;

/// <summary>
/// Abstract class for Abeillia (genus).
/// NCBI TaxId: 1507327
/// </summary>
public abstract class Abeillia : Trochilidae, IAbeillia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Abeillia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1507327;

    /// <inheritdoc />
    public virtual string GenusName => "Abeillia";

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
