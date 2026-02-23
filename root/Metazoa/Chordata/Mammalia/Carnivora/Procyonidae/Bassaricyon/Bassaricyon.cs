using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Procyonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Procyonidae.Bassaricyon;

/// <summary>
/// Abstract class for Bassaricyon (genus).
/// NCBI TaxId: 48421
/// </summary>
public abstract class Bassaricyon : Procyonidae, IBassaricyon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bassaricyon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48421;

    /// <inheritdoc />
    public virtual string GenusName => "Bassaricyon";

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
