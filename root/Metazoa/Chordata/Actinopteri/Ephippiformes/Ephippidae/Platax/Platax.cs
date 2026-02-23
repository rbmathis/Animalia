using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ephippiformes.Ephippidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ephippiformes.Ephippidae.Platax;

/// <summary>
/// Abstract class for Platax (genus).
/// NCBI TaxId: 75031
/// </summary>
public abstract class Platax : Ephippidae, IPlatax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75031;

    /// <inheritdoc />
    public virtual string GenusName => "Platax";

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
