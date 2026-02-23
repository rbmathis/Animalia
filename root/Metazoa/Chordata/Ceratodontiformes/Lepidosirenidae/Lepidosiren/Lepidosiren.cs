using AnimalKingdom.root.Metazoa.Chordata.Ceratodontiformes.Lepidosirenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ceratodontiformes.Lepidosirenidae.Lepidosiren;

/// <summary>
/// Abstract class for Lepidosiren (genus).
/// NCBI TaxId: 7881
/// </summary>
public abstract class Lepidosiren : Lepidosirenidae, ILepidosiren
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidosiren";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7881;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidosiren";

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
