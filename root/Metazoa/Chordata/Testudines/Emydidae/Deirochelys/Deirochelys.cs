using AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Deirochelys;

/// <summary>
/// Abstract class for Deirochelys (genus).
/// NCBI TaxId: 158818
/// </summary>
public abstract class Deirochelys : Emydidae, IDeirochelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Deirochelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 158818;

    /// <inheritdoc />
    public virtual string GenusName => "Deirochelys";

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
