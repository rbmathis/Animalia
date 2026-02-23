using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Compsura;

/// <summary>
/// Abstract class for Compsura (genus).
/// NCBI TaxId: 681906
/// </summary>
public abstract class Compsura : Characidae, ICompsura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Compsura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 681906;

    /// <inheritdoc />
    public virtual string GenusName => "Compsura";

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
