using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Leucopsarion;

/// <summary>
/// Abstract class for Leucopsarion (genus).
/// NCBI TaxId: 167317
/// </summary>
public abstract class Leucopsarion : Gobiidae, ILeucopsarion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leucopsarion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 167317;

    /// <inheritdoc />
    public virtual string GenusName => "Leucopsarion";

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
