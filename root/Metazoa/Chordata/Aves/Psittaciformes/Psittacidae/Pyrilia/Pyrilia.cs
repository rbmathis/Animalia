using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Pyrilia;

/// <summary>
/// Abstract class for Pyrilia (genus).
/// NCBI TaxId: 2259671
/// </summary>
public abstract class Pyrilia : Psittacidae, IPyrilia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pyrilia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2259671;

    /// <inheritdoc />
    public virtual string GenusName => "Pyrilia";

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
