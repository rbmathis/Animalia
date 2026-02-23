using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae.Falculea;

/// <summary>
/// Abstract class for Falculea (genus).
/// NCBI TaxId: 125308
/// </summary>
public abstract class Falculea : Vangidae, IFalculea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Falculea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 125308;

    /// <inheritdoc />
    public virtual string GenusName => "Falculea";

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
