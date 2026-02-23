using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Carlarius;

/// <summary>
/// Abstract class for Carlarius (genus).
/// NCBI TaxId: 591312
/// </summary>
public abstract class Carlarius : Ariidae, ICarlarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carlarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 591312;

    /// <inheritdoc />
    public virtual string GenusName => "Carlarius";

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
