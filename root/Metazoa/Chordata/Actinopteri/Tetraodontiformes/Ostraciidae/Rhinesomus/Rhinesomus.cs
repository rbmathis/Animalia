using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Ostraciidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Ostraciidae.Rhinesomus;

/// <summary>
/// Abstract class for Rhinesomus (genus).
/// NCBI TaxId: 1182261
/// </summary>
public abstract class Rhinesomus : Ostraciidae, IRhinesomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinesomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1182261;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinesomus";

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
