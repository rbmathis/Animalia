using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Procyonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Procyonidae.Procyon;

/// <summary>
/// Abstract class for Procyon (genus).
/// NCBI TaxId: 9653
/// </summary>
public abstract class Procyon : Procyonidae, IProcyon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Procyon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9653;

    /// <inheritdoc />
    public virtual string GenusName => "Procyon";

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
