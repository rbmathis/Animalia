using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Neomorphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Neomorphidae.Tapera;

/// <summary>
/// Abstract class for Tapera (genus).
/// NCBI TaxId: 78211
/// </summary>
public abstract class Tapera : Neomorphidae, ITapera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tapera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 78211;

    /// <inheritdoc />
    public virtual string GenusName => "Tapera";

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
