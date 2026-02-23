using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae.Leptonychotes;

/// <summary>
/// Abstract class for Leptonychotes (genus).
/// NCBI TaxId: 9712
/// </summary>
public abstract class Leptonychotes : Phocidae, ILeptonychotes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptonychotes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9712;

    /// <inheritdoc />
    public virtual string GenusName => "Leptonychotes";

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
