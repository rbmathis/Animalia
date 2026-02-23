using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae.Uropterygius;

/// <summary>
/// Abstract class for Uropterygius (genus).
/// NCBI TaxId: 189495
/// </summary>
public abstract class Uropterygius : Muraenidae, IUropterygius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Uropterygius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 189495;

    /// <inheritdoc />
    public virtual string GenusName => "Uropterygius";

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
