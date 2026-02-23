using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Brachypetersius;

/// <summary>
/// Abstract class for Brachypetersius (genus).
/// NCBI TaxId: 1144535
/// </summary>
public abstract class Brachypetersius : Alestidae, IBrachypetersius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachypetersius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1144535;

    /// <inheritdoc />
    public virtual string GenusName => "Brachypetersius";

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
