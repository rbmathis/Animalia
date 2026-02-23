using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Temnurus;

/// <summary>
/// Abstract class for Temnurus (genus).
/// NCBI TaxId: 257857
/// </summary>
public abstract class Temnurus : Corvidae, ITemnurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Temnurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 257857;

    /// <inheritdoc />
    public virtual string GenusName => "Temnurus";

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
