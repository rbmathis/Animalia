using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae.Forsterygion;

/// <summary>
/// Abstract class for Forsterygion (genus).
/// NCBI TaxId: 206114
/// </summary>
public abstract class Forsterygion : Tripterygiidae, IForsterygion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Forsterygion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 206114;

    /// <inheritdoc />
    public virtual string GenusName => "Forsterygion";

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
