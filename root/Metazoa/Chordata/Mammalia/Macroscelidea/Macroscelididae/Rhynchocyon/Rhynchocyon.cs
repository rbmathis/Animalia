using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Macroscelidea.Macroscelididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Macroscelidea.Macroscelididae.Rhynchocyon;

/// <summary>
/// Abstract class for Rhynchocyon (genus).
/// NCBI TaxId: 151030
/// </summary>
public abstract class Rhynchocyon : Macroscelididae, IRhynchocyon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhynchocyon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 151030;

    /// <inheritdoc />
    public virtual string GenusName => "Rhynchocyon";

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
