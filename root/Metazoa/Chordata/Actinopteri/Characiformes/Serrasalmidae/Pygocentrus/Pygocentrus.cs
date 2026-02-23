using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Pygocentrus;

/// <summary>
/// Abstract class for Pygocentrus (genus).
/// NCBI TaxId: 42513
/// </summary>
public abstract class Pygocentrus : Serrasalmidae, IPygocentrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pygocentrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42513;

    /// <inheritdoc />
    public virtual string GenusName => "Pygocentrus";

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
