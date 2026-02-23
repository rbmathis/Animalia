using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Gracupica;

/// <summary>
/// Abstract class for Gracupica (genus).
/// NCBI TaxId: 2781411
/// </summary>
public abstract class Gracupica : Sturnidae, IGracupica
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gracupica";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2781411;

    /// <inheritdoc />
    public virtual string GenusName => "Gracupica";

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
