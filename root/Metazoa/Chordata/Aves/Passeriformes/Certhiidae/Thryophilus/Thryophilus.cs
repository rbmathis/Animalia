using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Thryophilus;

/// <summary>
/// Abstract class for Thryophilus (genus).
/// NCBI TaxId: 1236216
/// </summary>
public abstract class Thryophilus : Certhiidae, IThryophilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thryophilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1236216;

    /// <inheritdoc />
    public virtual string GenusName => "Thryophilus";

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
