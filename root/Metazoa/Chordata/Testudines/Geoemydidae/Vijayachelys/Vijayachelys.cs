using AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Vijayachelys;

/// <summary>
/// Abstract class for Vijayachelys (genus).
/// NCBI TaxId: 1380079
/// </summary>
public abstract class Vijayachelys : Geoemydidae, IVijayachelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vijayachelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1380079;

    /// <inheritdoc />
    public virtual string GenusName => "Vijayachelys";

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
