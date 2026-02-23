using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae.Hylomys;

/// <summary>
/// Abstract class for Hylomys (genus).
/// NCBI TaxId: 48896
/// </summary>
public abstract class Hylomys : Erinaceidae, IHylomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hylomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48896;

    /// <inheritdoc />
    public virtual string GenusName => "Hylomys";

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
