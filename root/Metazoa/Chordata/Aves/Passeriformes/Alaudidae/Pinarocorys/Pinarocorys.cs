using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Pinarocorys;

/// <summary>
/// Abstract class for Pinarocorys (genus).
/// NCBI TaxId: 1365196
/// </summary>
public abstract class Pinarocorys : Alaudidae, IPinarocorys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pinarocorys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1365196;

    /// <inheritdoc />
    public virtual string GenusName => "Pinarocorys";

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
