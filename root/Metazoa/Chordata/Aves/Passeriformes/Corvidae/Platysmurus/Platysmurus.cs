using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Platysmurus;

/// <summary>
/// Abstract class for Platysmurus (genus).
/// NCBI TaxId: 257855
/// </summary>
public abstract class Platysmurus : Corvidae, IPlatysmurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platysmurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 257855;

    /// <inheritdoc />
    public virtual string GenusName => "Platysmurus";

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
