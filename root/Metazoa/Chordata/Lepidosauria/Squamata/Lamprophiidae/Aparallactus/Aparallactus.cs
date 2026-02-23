using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Aparallactus;

/// <summary>
/// Abstract class for Aparallactus (genus).
/// NCBI TaxId: 46263
/// </summary>
public abstract class Aparallactus : Lamprophiidae, IAparallactus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aparallactus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 46263;

    /// <inheritdoc />
    public virtual string GenusName => "Aparallactus";

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
