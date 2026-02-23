using AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae.Lophoceros;

/// <summary>
/// Abstract class for Lophoceros (genus).
/// NCBI TaxId: 2821869
/// </summary>
public abstract class Lophoceros : Bucerotidae, ILophoceros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophoceros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821869;

    /// <inheritdoc />
    public virtual string GenusName => "Lophoceros";

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
