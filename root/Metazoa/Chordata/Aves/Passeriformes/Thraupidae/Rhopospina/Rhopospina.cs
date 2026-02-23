using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Rhopospina;

/// <summary>
/// Abstract class for Rhopospina (genus).
/// NCBI TaxId: 2786904
/// </summary>
public abstract class Rhopospina : Thraupidae, IRhopospina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhopospina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2786904;

    /// <inheritdoc />
    public virtual string GenusName => "Rhopospina";

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
