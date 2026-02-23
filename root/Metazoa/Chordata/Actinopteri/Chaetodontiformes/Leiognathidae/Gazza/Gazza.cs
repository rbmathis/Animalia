using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae.Gazza;

/// <summary>
/// Abstract class for Gazza (genus).
/// NCBI TaxId: 218815
/// </summary>
public abstract class Gazza : Leiognathidae, IGazza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gazza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 218815;

    /// <inheritdoc />
    public virtual string GenusName => "Gazza";

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
