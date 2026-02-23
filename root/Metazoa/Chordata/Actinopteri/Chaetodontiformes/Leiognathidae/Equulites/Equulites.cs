using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae.Equulites;

/// <summary>
/// Abstract class for Equulites (genus).
/// NCBI TaxId: 334408
/// </summary>
public abstract class Equulites : Leiognathidae, IEquulites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Equulites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 334408;

    /// <inheritdoc />
    public virtual string GenusName => "Equulites";

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
