using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae.Nuchequula;

/// <summary>
/// Abstract class for Nuchequula (genus).
/// NCBI TaxId: 494374
/// </summary>
public abstract class Nuchequula : Leiognathidae, INuchequula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nuchequula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 494374;

    /// <inheritdoc />
    public virtual string GenusName => "Nuchequula";

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
