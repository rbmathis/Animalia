using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae.Leiognathus;

/// <summary>
/// Abstract class for Leiognathus (genus).
/// NCBI TaxId: 218801
/// </summary>
public abstract class Leiognathus : Leiognathidae, ILeiognathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leiognathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 218801;

    /// <inheritdoc />
    public virtual string GenusName => "Leiognathus";

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
