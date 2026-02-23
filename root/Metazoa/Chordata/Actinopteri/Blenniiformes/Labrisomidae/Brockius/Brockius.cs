using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae.Brockius;

/// <summary>
/// Abstract class for Brockius (genus).
/// NCBI TaxId: 2890333
/// </summary>
public abstract class Brockius : Labrisomidae, IBrockius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brockius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2890333;

    /// <inheritdoc />
    public virtual string GenusName => "Brockius";

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
