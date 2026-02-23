using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Nematogenyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Nematogenyidae.Nematogenys;

/// <summary>
/// Abstract class for Nematogenys (genus).
/// NCBI TaxId: 245785
/// </summary>
public abstract class Nematogenys : Nematogenyidae, INematogenys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nematogenys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245785;

    /// <inheritdoc />
    public virtual string GenusName => "Nematogenys";

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
