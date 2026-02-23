using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae.Karalla;

/// <summary>
/// Abstract class for Karalla (genus).
/// NCBI TaxId: 1751280
/// </summary>
public abstract class Karalla : Leiognathidae, IKaralla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Karalla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1751280;

    /// <inheritdoc />
    public virtual string GenusName => "Karalla";

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
