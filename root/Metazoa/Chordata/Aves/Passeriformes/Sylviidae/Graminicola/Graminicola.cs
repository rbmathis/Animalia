using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Graminicola;

/// <summary>
/// Abstract class for Graminicola (genus).
/// NCBI TaxId: 330741
/// </summary>
public abstract class Graminicola : Sylviidae, IGraminicola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Graminicola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 330741;

    /// <inheritdoc />
    public virtual string GenusName => "Graminicola";

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
