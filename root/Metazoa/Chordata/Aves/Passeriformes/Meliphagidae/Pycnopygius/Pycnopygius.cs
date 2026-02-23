using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Pycnopygius;

/// <summary>
/// Abstract class for Pycnopygius (genus).
/// NCBI TaxId: 266375
/// </summary>
public abstract class Pycnopygius : Meliphagidae, IPycnopygius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pycnopygius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 266375;

    /// <inheritdoc />
    public virtual string GenusName => "Pycnopygius";

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
