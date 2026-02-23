using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Spizocorys;

/// <summary>
/// Abstract class for Spizocorys (genus).
/// NCBI TaxId: 215316
/// </summary>
public abstract class Spizocorys : Alaudidae, ISpizocorys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spizocorys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 215316;

    /// <inheritdoc />
    public virtual string GenusName => "Spizocorys";

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
