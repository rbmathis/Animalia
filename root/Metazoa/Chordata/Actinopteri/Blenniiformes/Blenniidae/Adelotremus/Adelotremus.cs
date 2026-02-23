using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Adelotremus;

/// <summary>
/// Abstract class for Adelotremus (genus).
/// NCBI TaxId: 1962405
/// </summary>
public abstract class Adelotremus : Blenniidae, IAdelotremus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Adelotremus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1962405;

    /// <inheritdoc />
    public virtual string GenusName => "Adelotremus";

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
