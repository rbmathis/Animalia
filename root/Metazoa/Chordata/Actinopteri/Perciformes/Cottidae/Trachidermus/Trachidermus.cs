using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Trachidermus;

/// <summary>
/// Abstract class for Trachidermus (genus).
/// NCBI TaxId: 290629
/// </summary>
public abstract class Trachidermus : Cottidae, ITrachidermus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trachidermus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 290629;

    /// <inheritdoc />
    public virtual string GenusName => "Trachidermus";

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
