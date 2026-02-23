using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Isbrueckerichthys;

/// <summary>
/// Abstract class for Isbrueckerichthys (genus).
/// NCBI TaxId: 571818
/// </summary>
public abstract class Isbrueckerichthys : Loricariidae, IIsbrueckerichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Isbrueckerichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 571818;

    /// <inheritdoc />
    public virtual string GenusName => "Isbrueckerichthys";

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
